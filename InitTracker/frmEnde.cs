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
    public partial class frmEnde : Form
    {
        public frmEnde(bool blnVictory)
        {
            InitializeComponent();

            this.pcbFinale.Image = this.imlBackground.Images[blnVictory ? 0 : 1];
            this.ShowDialog();
        }

        
        private void frmEnde_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
