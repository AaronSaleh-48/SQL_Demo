namespace SQL
{
    partial class frmMain
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.txtDatabseName = new System.Windows.Forms.TextBox();
            this.txtCreateTable = new System.Windows.Forms.TextBox();
            this.lblConnectedToText = new System.Windows.Forms.Label();
            this.lblConnectedTo = new System.Windows.Forms.Label();
            this.tmrUpdateTables = new System.Windows.Forms.Timer(this.components);
            this.rtxTables = new System.Windows.Forms.RichTextBox();
            this.txtDeleteTable = new System.Windows.Forms.TextBox();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 44);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(210, 41);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Database";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(12, 149);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(210, 41);
            this.btnCreateTable.TabIndex = 1;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.BtnCreateDatabase_Click);
            // 
            // txtDatabseName
            // 
            this.txtDatabseName.Location = new System.Drawing.Point(12, 12);
            this.txtDatabseName.Name = "txtDatabseName";
            this.txtDatabseName.Size = new System.Drawing.Size(210, 26);
            this.txtDatabseName.TabIndex = 2;
            this.txtDatabseName.Text = "Database Name";
            // 
            // txtCreateTable
            // 
            this.txtCreateTable.Location = new System.Drawing.Point(12, 117);
            this.txtCreateTable.Name = "txtCreateTable";
            this.txtCreateTable.Size = new System.Drawing.Size(210, 26);
            this.txtCreateTable.TabIndex = 3;
            this.txtCreateTable.Text = "Create Table";
            // 
            // lblConnectedToText
            // 
            this.lblConnectedToText.AutoSize = true;
            this.lblConnectedToText.Location = new System.Drawing.Point(228, 18);
            this.lblConnectedToText.Name = "lblConnectedToText";
            this.lblConnectedToText.Size = new System.Drawing.Size(109, 20);
            this.lblConnectedToText.TabIndex = 4;
            this.lblConnectedToText.Text = "Connected to:";
            // 
            // lblConnectedTo
            // 
            this.lblConnectedTo.AutoSize = true;
            this.lblConnectedTo.Location = new System.Drawing.Point(343, 18);
            this.lblConnectedTo.Name = "lblConnectedTo";
            this.lblConnectedTo.Size = new System.Drawing.Size(14, 20);
            this.lblConnectedTo.TabIndex = 5;
            this.lblConnectedTo.Text = "-";
            // 
            // tmrUpdateTables
            // 
            this.tmrUpdateTables.Interval = 1;
            this.tmrUpdateTables.Tick += new System.EventHandler(this.TmrUpdateTables_Tick);
            // 
            // rtxTables
            // 
            this.rtxTables.Location = new System.Drawing.Point(590, 12);
            this.rtxTables.Name = "rtxTables";
            this.rtxTables.Size = new System.Drawing.Size(198, 178);
            this.rtxTables.TabIndex = 6;
            this.rtxTables.Text = "";
            // 
            // txtDeleteTable
            // 
            this.txtDeleteTable.Location = new System.Drawing.Point(12, 228);
            this.txtDeleteTable.Name = "txtDeleteTable";
            this.txtDeleteTable.Size = new System.Drawing.Size(210, 26);
            this.txtDeleteTable.TabIndex = 7;
            this.txtDeleteTable.Text = "Delete Table";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(12, 260);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(210, 41);
            this.btnDeleteTable.TabIndex = 8;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.BtnDeleteTable_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.txtDeleteTable);
            this.Controls.Add(this.rtxTables);
            this.Controls.Add(this.lblConnectedTo);
            this.Controls.Add(this.lblConnectedToText);
            this.Controls.Add(this.txtCreateTable);
            this.Controls.Add(this.txtDatabseName);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnConnect);
            this.Name = "frmMain";
            this.Text = "SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.TextBox txtDatabseName;
        private System.Windows.Forms.TextBox txtCreateTable;
        private System.Windows.Forms.Label lblConnectedToText;
        private System.Windows.Forms.Label lblConnectedTo;
        private System.Windows.Forms.Timer tmrUpdateTables;
        private System.Windows.Forms.RichTextBox rtxTables;
        private System.Windows.Forms.TextBox txtDeleteTable;
        private System.Windows.Forms.Button btnDeleteTable;
    }
}

