namespace InitTracker
{
    partial class frmEnde
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnde));
            this.pcbFinale = new System.Windows.Forms.PictureBox();
            this.imlBackground = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinale)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbFinale
            // 
            this.pcbFinale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbFinale.Location = new System.Drawing.Point(1, 1);
            this.pcbFinale.Name = "pcbFinale";
            this.pcbFinale.Size = new System.Drawing.Size(256, 256);
            this.pcbFinale.TabIndex = 0;
            this.pcbFinale.TabStop = false;
            this.pcbFinale.Click += new System.EventHandler(this.frmEnde_Click);
            // 
            // imlBackground
            // 
            this.imlBackground.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBackground.ImageStream")));
            this.imlBackground.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBackground.Images.SetKeyName(0, "victory.jpg");
            this.imlBackground.Images.SetKeyName(1, "youlose.jpg");
            // 
            // frmEnde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 258);
            this.ControlBox = false;
            this.Controls.Add(this.pcbFinale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnde";
            this.Click += new System.EventHandler(this.frmEnde_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFinale;
        private System.Windows.Forms.ImageList imlBackground;
    }
}