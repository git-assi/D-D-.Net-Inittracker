using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InitTracker
{
    namespace DetailForm
    {
        class clsDetailFormFactory
        {
            private frmDetail m_frmDetail = new frmDetail();

            private int m_intHOffset = 5;
            private int m_intVOffset = 5;

            internal void LoadByRowData(DataGridViewRow rowAkt)
            {
                try
                {
                    int intHOffset = 0;
                    foreach (DataGridViewCell cell in rowAkt.Cells)
                    {
                        string strName = cell.DataGridView.Columns[cell.ColumnIndex].Name;

                        if (!strName.StartsWith("_") && !strName.Contains("btn"))
                        {
                            intHOffset = m_intHOffset;

                            m_frmDetail.Controls.Add(makeLabel(strName, ref intHOffset));

                            Label conNew = makeLabel(cell.Value.ToString(), ref intHOffset);
                            m_frmDetail.Controls.Add(conNew);
                            m_intVOffset += conNew.Height + 5;
                        }
                    }

                    Control ctrl;
 
                    for (int i = 0; i <= 12; i++)
                    {
                        ctrl = makeButton (i.ToString(), ref intHOffset);
                        m_frmDetail.Controls.Add(ctrl);
                        if (intHOffset % 3 == 0)
                        {
                            intHOffset = m_intHOffset;
                            m_intVOffset += ctrl.Height + 5;
                        }
                    }

                    m_frmDetail.Height = m_intVOffset + 50;
                    m_frmDetail.Width  = intHOffset ;
                    m_frmDetail.ShowDialog();
                }
                catch (Exception ex)
                {
                    handleError(ex);
                }
            }

            private void handleError(Exception ex)
            {
                throw new NotImplementedException();
            }

            private Button makeButton(string strName, ref int intHOffset)
            {
                Button btn = new Button();
                btn.Location = new Point(intHOffset, m_intVOffset);
                btn.Text = strName;
                btn.Visible = true;
                btn.AutoSize = true;
                btn.Text = strName;
                return btn;
            }

            private Label makeLabel(string strName, ref int intHOffset)
            {
                Label conNew = new Label();
                conNew.Location = new Point(intHOffset, m_intVOffset);
                conNew.Name = "lbl" + strName;
                conNew.Visible = true;
                conNew.AutoSize = true;
                conNew.Text = strName;
                
                intHOffset += conNew.Width + 15;
                return conNew;
            }
        }
    }
}
