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
    public partial class frmSchaden : Form
    {
        private DataGridViewRow m_rowAkt;
        
        public frmSchaden()
        {
            InitializeComponent();
        }

        private void handleError(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        internal void LoadByRowData(DataGridViewRow rowAkt)
        {
            try
            {
                m_rowAkt = rowAkt;
                this.lblName.Text = m_rowAkt.Cells["Name"].Value.ToString();
                this.ShowDialog();
            }
            catch (Exception ex)
            {
                handleError(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text = textBox1.Text + ((Button)sender).Text;
                //int intNewValue = Convert.ToInt16(((Button)sender).Text);
                //int intValue = Convert.ToInt16(textBox1.Text);

                //textBox1.Text = (intValue + intNewValue).ToString();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int aktHPs = Convert.ToInt16(m_rowAkt.Cells["_HP_akt"].Value);
            int maxHPs = Convert.ToInt16(m_rowAkt.Cells["_HP"].Value);
            int intValue = Convert.ToInt16(textBox1.Text);
            
            if (m_blnDamageMode) 
                intValue *= -1;

            aktHPs += intValue;
            aktHPs = aktHPs < 0 ? 0 : aktHPs;
            m_rowAkt.Cells["_HP_akt"].Value = aktHPs > maxHPs ? maxHPs: aktHPs;
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnDamageHeal_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool m_blnDamageMode
        {
            get
            {
                return btnHealDamage.ForeColor == Color.Crimson;
            }
        }

        private void btnHealDamage_Click(object sender, EventArgs e)
        {
            try
            {
                btnHealDamage.ForeColor = m_blnDamageMode ? Color.Green : Color.Crimson;
                btnHealDamage.Text = m_blnDamageMode ? "Damage" : "Heal";
 
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
            }
        }

       

       

      
    }
}
