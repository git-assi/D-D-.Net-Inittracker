using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InitTracker
{
    public partial class Form1 : Form
    {
        private DataGridViewRow m_SelectedRow;

        

        public Form1()
        {
            InitializeComponent();

            grdFormat(grdInitiative);   
        }

        private void grdFormat(DataGridView grd)
        {
            try
            {
                grd.ReadOnly = true;

                grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grd.AllowUserToAddRows = false;
                grd.AllowUserToDeleteRows = false;
                grd.AllowUserToOrderColumns = true;
                grd.AllowUserToResizeRows = false;
                grd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                grd.MultiSelect = false;
                grd.ShowEditingIcon = false;
                grd.RowHeadersVisible = false;
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
                    if (colAkt.Name != "")
                    {
                        colAkt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else
                    {
                        colAkt.Width = 60;
                    }
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
                DataTable tblDemodaten = new DataTable();

                tblDemodaten.Columns.Add("selected", typeof(bool));
                tblDemodaten.Columns.Add("Name", typeof(string));
                tblDemodaten.Columns.Add("ooA", typeof(bool));                
                tblDemodaten.Columns.Add("image", typeof(string));

                for (int i = 0; i < 10; i++)
                {
                    DataRow newRow = tblDemodaten.NewRow();
                    newRow["Name"] = "Test No" + tblDemodaten.Rows.Count.ToString();
                    newRow["ooA"] = false;
                    newRow["selected"] = false;
                    newRow["image"] = "C:\\Entwicklung\\Tool - Release\\Resources\\Table.bmp";
                    tblDemodaten.Rows.Add(newRow);
                }

                grdInitiative.DataSource = tblDemodaten;

                grdInitiative.Columns["ooa"].Visible = false;
                grdInitiative.Columns["image"].Visible = false;

                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.HeaderText = "ooA";
                btnCol.Name = "btnooA";
                grdInitiative.Columns.Add(btnCol);

                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "imgCol";
                btnCol.HeaderText = "Bild";
                imgCol.Image = new Bitmap("C:\\Entwicklung\\Tool - Release\\Resources\\Table.bmp");
                grdInitiative.Columns.Add(imgCol);


                m_SelectedRow = grdInitiative.Rows[0];
                m_SelectedRow.Cells["selected"].Value = true;

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
                if (e.RowIndex > 0 && e.ColumnIndex == grdInitiative.Columns["btnooA"].Index)
                {
                    grdInitiative.Rows[e.RowIndex].Cells["ooA"].Value = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdInitiative_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > 0 && e.ColumnIndex > 0)
                {
                    if (Convert.ToBoolean(grdInitiative.Rows[e.RowIndex].Cells["ooA"].Value))
                    {
                        grdInitiative.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        grdInitiative.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {                        
                        grdInitiative.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        grdInitiative.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        Font altFont = grdInitiative.Rows[e.RowIndex].DefaultCellStyle.Font;
                        if (Convert.ToBoolean(grdInitiative.Rows[e.RowIndex].Cells["selected"].Value))
                        {
                            grdInitiative.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(altFont.Name, altFont.Size, FontStyle.Bold);
                        }
                        else
                        {
                            grdInitiative.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(altFont.Name, altFont.Size);
                        }
                    }
                }

                grdInitiative.SelectedRows[0].Selected = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdInitiative_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
