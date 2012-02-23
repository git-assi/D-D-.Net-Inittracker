namespace InitTracker
{
    partial class frmEncVerwalter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncVerwalter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbEncounter = new System.Windows.Forms.ComboBox();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.chkW20 = new System.Windows.Forms.CheckBox();
            this.grdEncounter = new System.Windows.Forms.DataGridView();
            this.cmsEncounterItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numHP = new System.Windows.Forms.NumericUpDown();
            this.numIni = new System.Windows.Forms.NumericUpDown();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnDemoDaten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEncounter)).BeginInit();
            this.cmsEncounterItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initiative";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.cmbType_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // cmbEncounter
            // 
            this.cmbEncounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEncounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncounter.DropDownWidth = 450;
            this.cmbEncounter.FormattingEnabled = true;
            this.cmbEncounter.Location = new System.Drawing.Point(12, 404);
            this.cmbEncounter.Name = "cmbEncounter";
            this.cmbEncounter.Size = new System.Drawing.Size(250, 21);
            this.cmbEncounter.TabIndex = 7;
            this.cmbEncounter.TabStop = false;
            this.cmbEncounter.SelectedValueChanged += new System.EventHandler(this.cmbEncounter_SelectedValueChanged);
            this.cmbEncounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // btnNeu
            // 
            this.btnNeu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeu.Location = new System.Drawing.Point(283, 385);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(50, 50);
            this.btnNeu.TabIndex = 8;
            this.btnNeu.TabStop = false;
            this.btnNeu.Text = "&New";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            this.btnNeu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(336, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(390, 385);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 50);
            this.btnDel.TabIndex = 6;
            this.btnDel.TabStop = false;
            this.btnDel.Text = "&Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            this.btnDel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // chkW20
            // 
            this.chkW20.AutoSize = true;
            this.chkW20.Location = new System.Drawing.Point(219, 34);
            this.chkW20.Name = "chkW20";
            this.chkW20.Size = new System.Drawing.Size(67, 17);
            this.chkW20.TabIndex = 3;
            this.chkW20.Text = "addW20";
            this.chkW20.UseVisualStyleBackColor = true;
            this.chkW20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // grdEncounter
            // 
            this.grdEncounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEncounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEncounter.ContextMenuStrip = this.cmsEncounterItem;
            this.grdEncounter.Location = new System.Drawing.Point(12, 60);
            this.grdEncounter.Name = "grdEncounter";
            this.grdEncounter.Size = new System.Drawing.Size(481, 320);
            this.grdEncounter.TabIndex = 14;
            this.grdEncounter.TabStop = false;
            this.grdEncounter.DataSourceChanged += new System.EventHandler(this.grdEncounter_DataSourceChanged);
            this.grdEncounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // cmsEncounterItem
            // 
            this.cmsEncounterItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem});
            this.cmsEncounterItem.Name = "cmsEncounterItem";
            this.cmsEncounterItem.Size = new System.Drawing.Size(114, 26);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(443, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // numHP
            // 
            this.numHP.Location = new System.Drawing.Point(119, 32);
            this.numHP.Name = "numHP";
            this.numHP.Size = new System.Drawing.Size(44, 20);
            this.numHP.TabIndex = 1;
            this.numHP.ValueChanged += new System.EventHandler(this.numHP_ValueChanged);
            this.numHP.Enter += new System.EventHandler(this.numHP_Enter);
            this.numHP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // numIni
            // 
            this.numIni.Location = new System.Drawing.Point(169, 32);
            this.numIni.Name = "numIni";
            this.numIni.Size = new System.Drawing.Size(44, 20);
            this.numIni.TabIndex = 2;
            this.numIni.ValueChanged += new System.EventHandler(this.numHP_ValueChanged);
            this.numIni.Enter += new System.EventHandler(this.numHP_Enter);
            this.numIni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "NSC",
            "Spieler"});
            this.cmbType.Location = new System.Drawing.Point(292, 31);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 4;
            this.cmbType.TextChanged += new System.EventHandler(this.cmbType_TextChanged);
            this.cmbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // btnDemoDaten
            // 
            this.btnDemoDaten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDemoDaten.Image = ((System.Drawing.Image)(resources.GetObject("btnDemoDaten.Image")));
            this.btnDemoDaten.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDemoDaten.Location = new System.Drawing.Point(443, 385);
            this.btnDemoDaten.Name = "btnDemoDaten";
            this.btnDemoDaten.Size = new System.Drawing.Size(50, 50);
            this.btnDemoDaten.TabIndex = 15;
            this.btnDemoDaten.UseVisualStyleBackColor = true;
            this.btnDemoDaten.Click += new System.EventHandler(this.btnDemoDaten_Click);
            this.btnDemoDaten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            // 
            // frmEncVerwalter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 437);
            this.Controls.Add(this.btnDemoDaten);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.numIni);
            this.Controls.Add(this.numHP);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdEncounter);
            this.Controls.Add(this.chkW20);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.cmbEncounter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEncVerwalter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Encounter Verwaltung";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEncounter_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdEncounter)).EndInit();
            this.cmsEncounterItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbEncounter;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.CheckBox chkW20;
        private System.Windows.Forms.DataGridView grdEncounter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numHP;
        private System.Windows.Forms.NumericUpDown numIni;
        private System.Windows.Forms.ContextMenuStrip cmsEncounterItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnDemoDaten;
    }
}