using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InitTracker
{
    class clsFormat
    {
        public static void grdFormat(System.Windows.Forms.DataGridView grd)
        {
            try
            {
                grd.ReadOnly = true;

                grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                grd.AllowUserToAddRows = false;
                grd.AllowUserToDeleteRows = false;
                grd.AllowUserToOrderColumns = true;
                grd.AllowUserToResizeRows = false;
                grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                grd.MultiSelect = false;
                grd.ShowEditingIcon = false;
                grd.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
