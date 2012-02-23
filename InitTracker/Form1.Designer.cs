namespace InitTracker
{
    partial class frmEncverwaltung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncverwaltung));
            this.grdInitiative = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbEncounter = new System.Windows.Forms.ComboBox();
            this.chkShowInv = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.encounterverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdInitiative)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdInitiative
            // 
            this.grdInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdInitiative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdInitiative.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdInitiative.Location = new System.Drawing.Point(11, 30);
            this.grdInitiative.Name = "grdInitiative";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            this.grdInitiative.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdInitiative.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInitiative.Size = new System.Drawing.Size(547, 370);
            this.grdInitiative.StandardTab = true;
            this.grdInitiative.TabIndex = 0;
            this.grdInitiative.DataSourceChanged += new System.EventHandler(this.grdInitiative_DataSourceChanged);
            this.grdInitiative.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInitiative_CellClick);
            this.grdInitiative.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grdInitiative_RowPrePaint);
            this.grdInitiative.SelectionChanged += new System.EventHandler(this.grdInitiative_SelectionChanged);
            this.grdInitiative.DoubleClick += new System.EventHandler(this.grdInitiative_DoubleClick);
            this.grdInitiative.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdInitiative_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(12, 412);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdInitiative_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(509, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdInitiative_KeyDown);
            // 
            // cmbEncounter
            // 
            this.cmbEncounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncounter.FormattingEnabled = true;
            this.cmbEncounter.Location = new System.Drawing.Point(105, 416);
            this.cmbEncounter.Name = "cmbEncounter";
            this.cmbEncounter.Size = new System.Drawing.Size(266, 21);
            this.cmbEncounter.TabIndex = 4;
            this.cmbEncounter.SelectedValueChanged += new System.EventHandler(this.cmbEncounter_SelectedValueChanged);
            this.cmbEncounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdInitiative_KeyDown);
            // 
            // chkShowInv
            // 
            this.chkShowInv.AutoSize = true;
            this.chkShowInv.Location = new System.Drawing.Point(105, 443);
            this.chkShowInv.Name = "chkShowInv";
            this.chkShowInv.Size = new System.Drawing.Size(88, 17);
            this.chkShowInv.TabIndex = 5;
            this.chkShowInv.Text = "show All Cols";
            this.chkShowInv.UseVisualStyleBackColor = true;
            this.chkShowInv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdInitiative_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encounterverwaltungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // encounterverwaltungToolStripMenuItem
            // 
            this.encounterverwaltungToolStripMenuItem.Name = "encounterverwaltungToolStripMenuItem";
            this.encounterverwaltungToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.encounterverwaltungToolStripMenuItem.Text = "Encountermanagement";
            this.encounterverwaltungToolStripMenuItem.Click += new System.EventHandler(this.encounterverwaltungToolStripMenuItem_Click);
            // 
            // frmEncverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 474);
            this.Controls.Add(this.chkShowInv);
            this.Controls.Add(this.cmbEncounter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grdInitiative);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEncverwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wheel of Fortune";
            ((System.ComponentModel.ISupportInitialize)(this.grdInitiative)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInitiative;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbEncounter;
        private System.Windows.Forms.CheckBox chkShowInv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem encounterverwaltungToolStripMenuItem;
    }
}

