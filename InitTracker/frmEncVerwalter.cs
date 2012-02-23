using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using InitTrackerBase;

namespace InitTracker
{
    public partial class frmEncVerwalter : Form
    {
        private clsInitTrackerDataSet m_dmlTracker;
        
        public frmEncVerwalter()
        {
            InitializeComponent();

            clsFormat.grdFormat(grdEncounter);

            m_dmlTracker = new clsInitTrackerDataSet();

            m_dmlTracker.onNewEncounterData += new clsInitTrackerDataSet.delDataTableEvent(m_dmlTracker_onNewEncounterData);
            m_dmlTracker.onNewEncounterList += new clsInitTrackerDataSet.delListTableEvent(m_dmlTracker_onNewEncounterList);

            m_dmlTracker.loadEncounterSets();
        }
        private void m_dmlTracker_onNewEncounterData(DataTable tblEncounter)
        {
            try
            {
                this.grdEncounter.DataSource = tblEncounter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        void m_dmlTracker_onNewEncounterList(List<string> lisEncList)
        {
            try
            {
                this.cmbEncounter.DataSource = lisEncList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnNeu_Click(object sender, EventArgs e)
        {
            try
            {
                string strEncName = "";

                if (clsInputBox.InputBox("Name eingeben", "Name des neuen Encounters", ref strEncName) == System.Windows.Forms.DialogResult.OK)
                {
                    
                    clsInitTrackerTable tblDemodaten = new clsInitTrackerTable(strEncName);
                    tblDemodaten.safeDataToFile();
                    m_dmlTracker.loadEncounterSets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void numHP_Enter(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private clsInitTrackerTable m_ittAktTable
        {
            get
            { 
                return (clsInitTrackerTable)grdEncounter.DataSource;
                
            }
        }

        private Int32 m_intHP
        {
            get
            {
                return Convert.ToInt32(numHP.Value);
            }
        }

        private clsWX m_W20 = new clsWX(20);

        private Int32 m_intIni
        {
            get
            {
                int intIni = Convert.ToInt32(numIni.Value);
                intIni += chkW20.Checked ? m_W20.Wurf() : 0;
                return intIni;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                m_ittAktTable.addRow(txtName.Text, m_intHP, m_intIni, cmbType.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdEncounter.SelectedRows.Count > 0)
                {
                    int intRow = grdEncounter.SelectedRows[0].Index;
                    m_ittAktTable.Rows[intRow].Delete();
                }

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                m_ittAktTable.safeDataToFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                m_ittAktTable.delSaveFile();
                m_dmlTracker.loadEncounterSets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdEncounter_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewColumn colAkt in grdEncounter.Columns)
                {
                    colAkt.Visible = !colAkt.Name.StartsWith("_");
                    colAkt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void checkAddButton()
        { 
            this.btnAdd.Enabled = numHP.Value > 0 && txtName.Text.Trim().Length > 0 && cmbType.Text != "";
        }
        private void numHP_ValueChanged(object sender, EventArgs e)
        {
            checkAddButton();
        }

        private void cmbType_TextChanged(object sender, EventArgs e)
        {
            checkAddButton();
        }

        private void grdEncounter_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                    this.Close();


                if (e.Control)
                {
                    //switch (e.KeyCode)
                    if (e.KeyCode == Keys.S)
                        this.btnSave_Click(sender, e);
                    if (e.KeyCode == Keys.D)
                        this.btnDel_Click(sender, e);
                    if (e.KeyCode == Keys.N)
                        this.btnNeu_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDemoDaten_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Create a random Encounter?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    clsInitTrackerTable tblDemodaten = new clsInitTrackerTable("Exampleencounter");

                    for (int i = 0; i < 10; i++)
                    {
                        tblDemodaten.addRowDefault(i <= 3);
                    }

                    tblDemodaten.safeDataToFile();
                    m_dmlTracker.loadEncounterSets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }    

    
    }
}
