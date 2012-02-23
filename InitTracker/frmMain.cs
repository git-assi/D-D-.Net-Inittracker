using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InitTrackerBase;

namespace InitTracker
{
    public partial class frmEncverwaltung : Form
    {
        private clsInitTrackerDataSet m_dmlTracker;

        private bool m_blnTPK
        {
            //total Player kill
            get
            {
                return getAliveCount("Spieler") == 0;
            }
        }

        private bool m_blnMonstersDead
        {
            //Players win
            get
            {
                return getAliveCount("NSC") == 0;
            }
        }
        private bool m_blnEncLoaded
        {
            get
            {
                return grdInitiative.DataSource != null && grdInitiative.RowCount > 0;
            }
        }

        private int getAliveCount(string strType)
        {
            string strExpression = "Type = '" + strType + "' AND _HP_akt > 0 ";
            return ((DataTable)grdInitiative.DataSource).Select(strExpression).Length;
        }

        public frmEncverwaltung()
        {
            try
            {
                InitializeComponent();
                m_dmlTracker = new clsInitTrackerDataSet();

                m_dmlTracker.onNewEncounterData += new clsInitTrackerDataSet.delDataTableEvent(m_dmlTracker_onNewEncounterData);
                m_dmlTracker.onNewEncounterList += new clsInitTrackerDataSet.delListTableEvent(m_dmlTracker_onNewEncounterList);
                m_dmlTracker.onNewTableError += new clsInitTrackerDataSet.delErrorEvent(dstEcounterDS_onNewTableError);
                m_dmlTracker.onNewIniIndex += new clsInitTrackerDataSet.delIndexEvent(m_dmlTracker_onNewIniIndex);
                m_dmlTracker.onRefresh += new clsInitTrackerDataSet.delObjectEvent(m_dmlTracker_onRefresh);

                clsFormat.grdFormat(grdInitiative);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
               
        }

        void m_dmlTracker_onRefresh(object objSomething)
        {
            try
            {
                //this.grdInitiative.
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        void m_dmlTracker_onNewIniIndex(int intNewIndex)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void dstEcounterDS_onNewTableError(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }


        void m_dmlTracker_onNewEncounterList(List<string> lisEncList)
        {
            try
            {
                cmbEncounter.DataSource = lisEncList;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void m_dmlTracker_onNewEncounterData(DataTable tblEncounter)
        {
            try
            {
                intIndex = 0;
                this.grdInitiative.DataSource = tblEncounter;
                if (tblEncounter.Rows.Count > 0)
                {
                    this.grdInitiative.Rows[intIndex].Cells["_hasIni"].Value = true;

                    if (!this.grdInitiative.Columns.Contains("btnSchaden"))
                    {
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        this.grdInitiative.Columns.Add(btn);
                        btn.Text = "Schaden";
                        btn.Name = "btnSchaden";
                        btn.HeaderText = "";
                        btn.UseColumnTextForButtonValue = true;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Width = 75;
                    }
                }
                /*btn = new DataGridViewButtonColumn();
                this.grdInitiative.Columns.Add(btn);
                btn.Text = "Details";
                btn.Name = "btnDetails";
                btn.HeaderText = "";
                btn.UseColumnTextForButtonValue = true;
                btn.Width = 75;
                */

                foreach (DataGridViewRow aktRow in this.grdInitiative.Rows)
                {
                    setRowColor(aktRow);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdInitiative_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewColumn colAkt in grdInitiative.Columns)
                {
                    colAkt.Visible = !(colAkt.Name.StartsWith("_") && !this.chkShowInv.Checked);
                    colAkt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
                }                                           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        int intIndex = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!m_blnEncLoaded)
                return;

            try
            {
                if (m_blnMonstersDead || m_blnTPK)
                {
                    new frmEnde(m_blnMonstersDead);
                }
                else
                {
                    btnNext.Enabled = false;

                    this.grdInitiative.Rows[intIndex].Cells["_hasIni"].Value = false;
                    setRowColor(this.grdInitiative.Rows[intIndex]);

                    getNextIndex();

                    this.grdInitiative.Rows[intIndex].Cells["_hasIni"].Value = true;
                    setRowColor(this.grdInitiative.Rows[intIndex]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                btnNext.Enabled = true;
            }
        }

        private void getNextIndex()
        {
            try
            {
                int intCounter = grdInitiative.Rows.Count;
                intIndex = intIndex < grdInitiative.Rows.Count - 1 ? ++intIndex : 0;

                int intHPAkt = Convert.ToInt16(grdInitiative.Rows[intIndex].Cells["_HP_akt"].Value);
                string strType = grdInitiative.Rows[intIndex].Cells["Type"].Value.ToString();

                while ( (intHPAkt <= 0 && strType == "NSC") && intCounter > 0)
                {
                    intCounter -= 1;
                    intIndex = intIndex >= grdInitiative.Rows.Count ? 0 : ++intIndex;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void setRowColor(DataGridViewRow aktRow)
        {
            int intHPakt = Convert.ToInt16(aktRow.Cells["_HP_akt"].Value);
            int intHPs = Convert.ToInt16(aktRow.Cells["_HP"].Value);

            bool blnSelected = Convert.ToBoolean(aktRow.Cells["_hasIni"].Value);
            bool blnBloodied = intHPakt <= (intHPs / 2);
            bool blnDead = intHPakt <= 0;

            aktRow.Height = blnSelected ? 30 : 25;

            foreach (DataGridViewCell aktCell in aktRow.Cells)
            {
                try
                {

                    if (!grdInitiative.Columns[aktCell.ColumnIndex].Name.StartsWith("btn"))
                    {
                        aktCell.Style.Font = new Font(grdInitiative.DefaultCellStyle.Font.Name, grdInitiative.DefaultCellStyle.Font.Size + (blnSelected ? 3 : 0), blnSelected ? FontStyle.Bold : FontStyle.Regular);
                       
                        if (blnDead)
                        {
                            aktCell.Style.BackColor = Color.Red;
                            aktCell.Style.ForeColor = Color.White;
                        }
                        else if (blnBloodied)
                        {
                            aktCell.Style.BackColor = Color.White;
                            aktCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            aktCell.Style.BackColor = Color.White;
                            aktCell.Style.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        aktCell.Style.BackColor = Color.White;
                        aktCell.Style.ForeColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void setRowColor_(DataGridViewRow dataGridViewRow)
        {
            int intHPakt = Convert.ToInt16(dataGridViewRow.Cells["_HP_akt"].Value);
            int intHPs = Convert.ToInt16(dataGridViewRow.Cells["_HP"].Value);

            bool blnSelected = Convert.ToBoolean(dataGridViewRow.Cells["_hasIni"].Value);
            bool blnBloodied = intHPakt <= (intHPs / 2);
            bool blnDead = intHPakt <= 0;

            foreach (DataGridViewCell aktCell in dataGridViewRow.Cells)
            {

                try
                {

                    if (!grdInitiative.Columns[aktCell.ColumnIndex].Name.StartsWith("btn"))
                    {
                        aktCell.Style.BackColor = (blnSelected ? Color.Red : Color.White);
                        aktCell.Style.ForeColor = (blnSelected ? Color.White : Color.Black);

                        if (blnDead)
                            aktCell.Style.Font = new Font(grdInitiative.DefaultCellStyle.Font.Name, grdInitiative.DefaultCellStyle.Font.Size, FontStyle.Bold);
                        else if (blnBloodied)
                            aktCell.Style.Font = new Font(grdInitiative.DefaultCellStyle.Font.Name, grdInitiative.DefaultCellStyle.Font.Size, FontStyle.Italic);
                        else
                            aktCell.Style.Font = new Font(grdInitiative.DefaultCellStyle.Font.Name, grdInitiative.DefaultCellStyle.Font.Size, FontStyle.Regular);
                    }
                    else
                    {
                        aktCell.Style.BackColor = Color.White;
                        aktCell.Style.ForeColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            m_dmlTracker.loadEncounterSets();
        }


        private void cmbEncounter_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEncounter.SelectedValue == null)
                    return;

                string strName = (string)cmbEncounter.SelectedValue;

                if (strName != "")
                    m_dmlTracker.selectEncounterSet(strName);
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdInitiative_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                
                    InitTracker.DetailForm.clsDetailFormFactory objForm = new DetailForm.clsDetailFormFactory();
                    objForm.LoadByRowData(grdInitiative.Rows[intIndex]);
                
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
            }
        }

        private void grdInitiative_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow aktRow in grdInitiative.SelectedRows)
                {
                    aktRow.Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdInitiative_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                    grdInitiative.Rows[intIndex].Cells["_HP_akt"].Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdInitiative_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (grdInitiative.Columns[e.ColumnIndex].GetType().ToString() == "System.Windows.Forms.DataGridViewButtonColumn")
                    onGridButtonClick(e.RowIndex, (DataGridViewButtonColumn)grdInitiative.Columns[e.ColumnIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void onGridButtonClick(int intIndex, DataGridViewButtonColumn sender)
        {
            if (sender.Name == "btnSchaden")
            {
                frmSchaden objForm = new frmSchaden();
                objForm.LoadByRowData(grdInitiative.Rows[intIndex]);
                setRowColor(grdInitiative.Rows[intIndex]);
            }
            else if (sender.Name == "btnDetails")
            {
                InitTracker.DetailForm.clsDetailFormFactory objForm = new DetailForm.clsDetailFormFactory();
                objForm.LoadByRowData(grdInitiative.Rows[intIndex]);
            }
        }

        private void grdInitiative_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                int intRow = e.RowIndex;

                //grdInitiative.Rows[intRow].Height = 30;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void encounterverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEncVerwalter frm = new frmEncVerwalter();
            frm.ShowDialog();
            m_dmlTracker.loadEncounterSets();
        }

        private void finaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

     
        

                
    }
}
