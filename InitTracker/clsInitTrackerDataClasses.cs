using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace InitTrackerBase
{
    public class clsInitTrackerTable : DataTable
    {
        private clsWX m_W20 = new clsWX(20);

        public clsInitTrackerTable(string strTablename)
        {
            this.TableName = strTablename;

            this.Namespace = "InitTracker";

            this.Columns.Add("Name", typeof(string));
            this.Columns.Add("Initiative", typeof(int));
            this.Columns.Add("_HP", typeof(int));
            this.Columns.Add("_HP_akt", typeof(int));
            //this.Columns.Add("_ImagePath", typeof(string));
            this.Columns.Add("_hasIni", typeof(bool));
            this.Columns.Add("Type", typeof(string));
        }

        public DataRow addRowDefault(bool blnSC)
        {
            return addRowDefault("", 0, 0, (blnSC ? "SC" : "NSC"), true);
        }

        public DataRow addRow(string strName, int intHP, int intInitiative, string strType)
        {
            return addRowDefault(strName, intHP, intInitiative, strType, true);
        }

        public DataRow addRowDefault(string strName, int intHP, int intInitiative, string strType, bool blnAddToSelf)
        {
            //Alle Spalten default vorfüllen, ggf. neue entsprechend erweitern
            DataRow newRow = this.NewRow();
            newRow["Name"] = strName != "" ? strName : (strType == "NSC" ? "Monster " : "Player ") + this.Rows.Count.ToString("00");
            newRow["_HP"] = intHP == 0 ? 5 + m_W20.Wurf() : intHP;
            newRow["_HP_akt"] = newRow["_HP"];
            newRow["Initiative"] = intInitiative;
            newRow["_hasIni"] = false;
            
            newRow["Type"] = strType;
            if (blnAddToSelf)
                this.Rows.Add(newRow);

            return newRow;
        }
        
        public void setSelectedRow(int intRowID)
        {
            foreach (DataRow row in this.Rows)
            {                
                if (this.Rows.IndexOf(row) == intRowID)
                {
                    row["_hasIni"] = true;
                    break;
                }
            }
            
        }

        private string m_strDefaultFileName
        {
            get
            { 
                return this.TableName + ".enc";
            }
        }
        
        public void safeDataToFile()
        {
            this.safeDataToFile(m_strDefaultFileName);
        }
        public void safeDataToFile(string strFileName)
        {
            this.WriteXml(strFileName);
        }

        internal void delSaveFile()
        {
            delSaveFile(m_strDefaultFileName);
        }

        internal void delSaveFile(string strFileName)
        {
            System.IO.File.Delete(strFileName);
        }
    }

    public class clsInitTrackerDataSet 
    {
        Dictionary<string, clsInitTrackerTable> m_dicEncounters = new Dictionary<string, clsInitTrackerTable>();
             
        public clsInitTrackerDataSet() : base()
        {
            
        }

       
        public delegate void delErrorEvent(Exception ex);
        public event delErrorEvent onNewTableError;
        private void raiseNewTableError(Exception ex)
        {
            if (onNewTableError != null)
                onNewTableError(ex);
        }

        public delegate void delDataTableEvent(DataTable tblEncList);
        public event delDataTableEvent onNewEncounterData;
        private void raiseNewEncounterData(DataTable tblEncounter)
        {
            if (onNewEncounterData != null)
                onNewEncounterData(tblEncounter);
        }

        public delegate void delObjectEvent(object objSomething);
        public event delObjectEvent onRefresh;
        private void raiseRefresh(object objSomething)
        {
            if (onRefresh != null)
                onRefresh(objSomething);
        }

        public delegate void delIndexEvent(int intNewIndex);
        public event delIndexEvent onNewIniIndex;
        private void raiseNewIndex(int intNewIndex)
        {
            if (onNewIniIndex != null)
                onNewIniIndex(intNewIndex);
        }
        
        public delegate void delListTableEvent(List<string> lisEncList);
        public event delListTableEvent onNewEncounterList;
        private void raiseNewEncounterList(List<string> lisEncounters)
        {
            if (onNewEncounterList != null)
                onNewEncounterList(lisEncounters);
        }

       
        public string LoadFromXMLFile(string strFile)
        {
            if (!System.IO.File.Exists(strFile))
            {
                throw new Exception("File existiert nicht");
            }

            clsEncounter objEnc = new clsEncounter(strFile);
            clsInitTrackerTable tblEncounter = new clsInitTrackerTable(objEnc.strName);
            tblEncounter.ReadXml(strFile);

            this.m_dicEncounters.Add(objEnc.strName, tblEncounter);

            
            return tblEncounter.TableName;
        }

        public void loadEncounterSets()
        {
            loadEncounterSets(".\\");
        }

        public void loadEncounterSets(string strPath)
        {
            m_dicEncounters.Clear();

            List<string> lisEncNames = new List<string>();
            try
            {
                string[] Files =System.IO.Directory.GetFiles(strPath, "*.enc");
                DataTable tblEncounterList = new DataTable();

                foreach (string strEnc in Files)
                {
                    string strNewEnc = LoadFromXMLFile(strEnc);
                    if (strNewEnc != "")
                        lisEncNames.Add(strNewEnc);
                }

                raiseNewEncounterList(lisEncNames);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        clsInitTrackerTable m_tblSelectedEnc = null;

        public void selectEncounterSet(string strEncName)
        {
            if (this.m_dicEncounters.ContainsKey(strEncName))
            {
                
                m_tblSelectedEnc = this.m_dicEncounters[strEncName];
                m_tblSelectedEnc.DefaultView.Sort = "Initiative desc";
               
                onNewEncounterData(m_tblSelectedEnc);
            }
            else
                throw new Exception("unbekannte Encounter Tabelle: " + strEncName);                
        }

               
        public void SelectNextRowByIni()
        {
            try
            {
               IEnumerable<DataRow> query =
                    from contact in m_tblSelectedEnc.AsEnumerable()
                    orderby contact.Field<int>("Initiative") descending 
                    select contact;

               bool blnFound = false;
               DataRow rowFirst = null;

                foreach (DataRow contact in query)
                {
                    if (rowFirst == null)
                    {
                        rowFirst = contact;
                    }
                    
                    if (blnFound)
                    {
                        //die nächste Zeile nach der aktuellen Ini
                        if (contact.Field<int>("HP akt") > 0)
                        {
                            contact["_hasIni"] = true;
                            break;
                        }
                    }
                    
                    if (contact.Field<bool>("_hasIni"))
                    {
                        contact["_hasIni"] = false;
                        blnFound = true;
                    }
                    
                }

                if (!blnFound)
                {
                    if (rowFirst.Field<int>("HP akt") > 0)
                        rowFirst["_hasIni"] = true;
                    else
                        onNewEncounterData(null);
                }

                onRefresh(null);    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
