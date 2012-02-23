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
    namespace DetailForm
    {
        public partial class frmDetail : Form
        {
            public frmDetail()
            {
                InitializeComponent();
            }

            private void handleError(Exception ex)
            {
                throw new NotImplementedException();
            }

            private void frmDetail_KeyUp(object sender, KeyEventArgs e)
            {
                try
                {
                    switch (e.KeyCode)
                    { 
                        case Keys.Escape :
                                this.Close();
                                break;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
