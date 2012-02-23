namespace InitTracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grdInitiative = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDemoDaten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdInitiative)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInitiative
            // 
            this.grdInitiative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInitiative.Location = new System.Drawing.Point(12, 12);
            this.grdInitiative.Name = "grdInitiative";
            this.grdInitiative.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInitiative.Size = new System.Drawing.Size(547, 394);
            this.grdInitiative.TabIndex = 0;
            this.grdInitiative.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInitiative_CellValueChanged);
            this.grdInitiative.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grdInitiative_RowPrePaint);
            this.grdInitiative.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInitiative_CellClick);
            this.grdInitiative.DataSourceChanged += new System.EventHandler(this.grdInitiative_DataSourceChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(509, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDemoDaten
            // 
            this.btnDemoDaten.Image = ((System.Drawing.Image)(resources.GetObject("btnDemoDaten.Image")));
            this.btnDemoDaten.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDemoDaten.Location = new System.Drawing.Point(258, 412);
            this.btnDemoDaten.Name = "btnDemoDaten";
            this.btnDemoDaten.Size = new System.Drawing.Size(50, 50);
            this.btnDemoDaten.TabIndex = 3;
            this.btnDemoDaten.UseVisualStyleBackColor = true;
            this.btnDemoDaten.Click += new System.EventHandler(this.btnDemoDaten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 474);
            this.Controls.Add(this.btnDemoDaten);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdInitiative);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdInitiative)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInitiative;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDemoDaten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}

