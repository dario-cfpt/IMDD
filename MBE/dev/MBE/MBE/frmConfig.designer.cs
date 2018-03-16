namespace MBE
{
    partial class frmConfig
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConfig = new System.Windows.Forms.Label();
            this.lblWindowURL = new System.Windows.Forms.Label();
            this.lblCustomConfigName = new System.Windows.Forms.Label();
            this.cbxConfig = new System.Windows.Forms.ComboBox();
            this.tbxWindowURL = new System.Windows.Forms.TextBox();
            this.gbFormat = new System.Windows.Forms.GroupBox();
            this.chkZoomBottom = new System.Windows.Forms.CheckBox();
            this.chkZoomLeft = new System.Windows.Forms.CheckBox();
            this.chkZoomRight = new System.Windows.Forms.CheckBox();
            this.chkZoomTop = new System.Windows.Forms.CheckBox();
            this.cbxViewType = new System.Windows.Forms.ComboBox();
            this.lblViewType = new System.Windows.Forms.Label();
            this.lblNbRow = new System.Windows.Forms.Label();
            this.nudCol = new System.Windows.Forms.NumericUpDown();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.tbxCustomFormat = new System.Windows.Forms.TextBox();
            this.rdbCustom = new System.Windows.Forms.RadioButton();
            this.rdbExcel = new System.Windows.Forms.RadioButton();
            this.rdbRowCol = new System.Windows.Forms.RadioButton();
            this.lblNbCol = new System.Windows.Forms.Label();
            this.tbxCustomConfigName = new System.Windows.Forms.TextBox();
            this.btnAddConfig = new System.Windows.Forms.Button();
            this.btnDeleteConfig = new System.Windows.Forms.Button();
            this.btnModifyConfig = new System.Windows.Forms.Button();
            this.btnLauchEmulator = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(30, 44);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(78, 13);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.Text = "Configuration : ";
            // 
            // lblWindowURL
            // 
            this.lblWindowURL.AutoSize = true;
            this.lblWindowURL.Location = new System.Drawing.Point(12, 73);
            this.lblWindowURL.Name = "lblWindowURL";
            this.lblWindowURL.Size = new System.Drawing.Size(96, 13);
            this.lblWindowURL.TabIndex = 1;
            this.lblWindowURL.Text = "URL des fenêtres :";
            // 
            // lblCustomConfigName
            // 
            this.lblCustomConfigName.AutoSize = true;
            this.lblCustomConfigName.Location = new System.Drawing.Point(12, 344);
            this.lblCustomConfigName.Name = "lblCustomConfigName";
            this.lblCustomConfigName.Size = new System.Drawing.Size(193, 13);
            this.lblCustomConfigName.TabIndex = 2;
            this.lblCustomConfigName.Text = "Nom de la configuration personnalisée :";
            // 
            // cbxConfig
            // 
            this.cbxConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConfig.FormattingEnabled = true;
            this.cbxConfig.Items.AddRange(new object[] {
            "Test1",
            "Test2"});
            this.cbxConfig.Location = new System.Drawing.Point(114, 41);
            this.cbxConfig.Name = "cbxConfig";
            this.cbxConfig.Size = new System.Drawing.Size(308, 21);
            this.cbxConfig.TabIndex = 3;
            this.cbxConfig.SelectedIndexChanged += new System.EventHandler(this.cbxConfig_SelectedIndexChanged);
            // 
            // tbxWindowURL
            // 
            this.tbxWindowURL.Location = new System.Drawing.Point(114, 73);
            this.tbxWindowURL.Name = "tbxWindowURL";
            this.tbxWindowURL.Size = new System.Drawing.Size(308, 20);
            this.tbxWindowURL.TabIndex = 4;
            this.tbxWindowURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWindowURL_KeyPress);
            // 
            // gbFormat
            // 
            this.gbFormat.Controls.Add(this.chkZoomBottom);
            this.gbFormat.Controls.Add(this.chkZoomLeft);
            this.gbFormat.Controls.Add(this.chkZoomRight);
            this.gbFormat.Controls.Add(this.chkZoomTop);
            this.gbFormat.Controls.Add(this.cbxViewType);
            this.gbFormat.Controls.Add(this.lblViewType);
            this.gbFormat.Controls.Add(this.lblNbRow);
            this.gbFormat.Controls.Add(this.nudCol);
            this.gbFormat.Controls.Add(this.nudRow);
            this.gbFormat.Controls.Add(this.tbxCustomFormat);
            this.gbFormat.Controls.Add(this.rdbCustom);
            this.gbFormat.Controls.Add(this.rdbExcel);
            this.gbFormat.Controls.Add(this.rdbRowCol);
            this.gbFormat.Location = new System.Drawing.Point(15, 112);
            this.gbFormat.Name = "gbFormat";
            this.gbFormat.Size = new System.Drawing.Size(407, 211);
            this.gbFormat.TabIndex = 5;
            this.gbFormat.TabStop = false;
            this.gbFormat.Text = "Format";
            // 
            // chkZoomBottom
            // 
            this.chkZoomBottom.AutoSize = true;
            this.chkZoomBottom.Location = new System.Drawing.Point(215, 188);
            this.chkZoomBottom.Name = "chkZoomBottom";
            this.chkZoomBottom.Size = new System.Drawing.Size(73, 17);
            this.chkZoomBottom.TabIndex = 12;
            this.chkZoomBottom.Text = "Zoom bas";
            this.chkZoomBottom.UseVisualStyleBackColor = true;
            // 
            // chkZoomLeft
            // 
            this.chkZoomLeft.AutoSize = true;
            this.chkZoomLeft.Location = new System.Drawing.Point(110, 157);
            this.chkZoomLeft.Name = "chkZoomLeft";
            this.chkZoomLeft.Size = new System.Drawing.Size(92, 17);
            this.chkZoomLeft.TabIndex = 11;
            this.chkZoomLeft.Text = "Zoom gauche";
            this.chkZoomLeft.UseVisualStyleBackColor = true;
            // 
            // chkZoomRight
            // 
            this.chkZoomRight.AutoSize = true;
            this.chkZoomRight.Location = new System.Drawing.Point(318, 157);
            this.chkZoomRight.Name = "chkZoomRight";
            this.chkZoomRight.Size = new System.Drawing.Size(76, 17);
            this.chkZoomRight.TabIndex = 10;
            this.chkZoomRight.Text = "Zoom droit";
            this.chkZoomRight.UseVisualStyleBackColor = true;
            // 
            // chkZoomTop
            // 
            this.chkZoomTop.AutoSize = true;
            this.chkZoomTop.Location = new System.Drawing.Point(215, 132);
            this.chkZoomTop.Name = "chkZoomTop";
            this.chkZoomTop.Size = new System.Drawing.Size(77, 17);
            this.chkZoomTop.TabIndex = 9;
            this.chkZoomTop.Text = "Zoom haut";
            this.chkZoomTop.UseVisualStyleBackColor = true;
            // 
            // cbxViewType
            // 
            this.cbxViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxViewType.FormattingEnabled = true;
            this.cbxViewType.Items.AddRange(new object[] {
            "Standard",
            "Zoomé"});
            this.cbxViewType.Location = new System.Drawing.Point(18, 153);
            this.cbxViewType.Name = "cbxViewType";
            this.cbxViewType.Size = new System.Drawing.Size(85, 21);
            this.cbxViewType.TabIndex = 8;
            this.cbxViewType.SelectedIndexChanged += new System.EventHandler(this.cbxViewType_SelectedIndexChanged);
            // 
            // lblViewType
            // 
            this.lblViewType.AutoSize = true;
            this.lblViewType.Location = new System.Drawing.Point(15, 136);
            this.lblViewType.Name = "lblViewType";
            this.lblViewType.Size = new System.Drawing.Size(73, 13);
            this.lblViewType.TabIndex = 7;
            this.lblViewType.Text = "Type de vue :";
            // 
            // lblNbRow
            // 
            this.lblNbRow.AutoSize = true;
            this.lblNbRow.Location = new System.Drawing.Point(262, 38);
            this.lblNbRow.Name = "lblNbRow";
            this.lblNbRow.Size = new System.Drawing.Size(52, 13);
            this.lblNbRow.TabIndex = 6;
            this.lblNbRow.Text = "NbLignes";
            // 
            // nudCol
            // 
            this.nudCol.Location = new System.Drawing.Point(350, 87);
            this.nudCol.Name = "nudCol";
            this.nudCol.Size = new System.Drawing.Size(34, 20);
            this.nudCol.TabIndex = 5;
            // 
            // nudRow
            // 
            this.nudRow.Location = new System.Drawing.Point(275, 87);
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(34, 20);
            this.nudRow.TabIndex = 4;
            // 
            // tbxCustomFormat
            // 
            this.tbxCustomFormat.Location = new System.Drawing.Point(109, 86);
            this.tbxCustomFormat.Name = "tbxCustomFormat";
            this.tbxCustomFormat.Size = new System.Drawing.Size(119, 20);
            this.tbxCustomFormat.TabIndex = 3;
            // 
            // rdbCustom
            // 
            this.rdbCustom.AutoSize = true;
            this.rdbCustom.Location = new System.Drawing.Point(18, 86);
            this.rdbCustom.Name = "rdbCustom";
            this.rdbCustom.Size = new System.Drawing.Size(85, 17);
            this.rdbCustom.TabIndex = 2;
            this.rdbCustom.TabStop = true;
            this.rdbCustom.Text = "Personnalisé";
            this.rdbCustom.UseVisualStyleBackColor = true;
            this.rdbCustom.CheckedChanged += new System.EventHandler(this.rdbCustom_CheckedChanged);
            // 
            // rdbExcel
            // 
            this.rdbExcel.AutoSize = true;
            this.rdbExcel.Location = new System.Drawing.Point(177, 34);
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Size = new System.Drawing.Size(51, 17);
            this.rdbExcel.TabIndex = 1;
            this.rdbExcel.TabStop = true;
            this.rdbExcel.Text = "Excel";
            this.rdbExcel.UseVisualStyleBackColor = true;
            // 
            // rdbRowCol
            // 
            this.rdbRowCol.AutoSize = true;
            this.rdbRowCol.Location = new System.Drawing.Point(18, 34);
            this.rdbRowCol.Name = "rdbRowCol";
            this.rdbRowCol.Size = new System.Drawing.Size(111, 17);
            this.rdbRowCol.TabIndex = 0;
            this.rdbRowCol.TabStop = true;
            this.rdbRowCol.Text = "Lignes / Colonnes";
            this.rdbRowCol.UseVisualStyleBackColor = true;
            // 
            // lblNbCol
            // 
            this.lblNbCol.AutoSize = true;
            this.lblNbCol.Location = new System.Drawing.Point(347, 150);
            this.lblNbCol.Name = "lblNbCol";
            this.lblNbCol.Size = new System.Drawing.Size(66, 13);
            this.lblNbCol.TabIndex = 7;
            this.lblNbCol.Text = "NBColonnes";
            // 
            // tbxCustomConfigName
            // 
            this.tbxCustomConfigName.Enabled = false;
            this.tbxCustomConfigName.Location = new System.Drawing.Point(211, 344);
            this.tbxCustomConfigName.Name = "tbxCustomConfigName";
            this.tbxCustomConfigName.Size = new System.Drawing.Size(211, 20);
            this.tbxCustomConfigName.TabIndex = 13;
            // 
            // btnAddConfig
            // 
            this.btnAddConfig.Enabled = false;
            this.btnAddConfig.Location = new System.Drawing.Point(211, 381);
            this.btnAddConfig.Name = "btnAddConfig";
            this.btnAddConfig.Size = new System.Drawing.Size(211, 23);
            this.btnAddConfig.TabIndex = 14;
            this.btnAddConfig.Text = "Ajouter la configuration";
            this.btnAddConfig.UseVisualStyleBackColor = true;
            this.btnAddConfig.Click += new System.EventHandler(this.btnAddConfig_Click);
            // 
            // btnDeleteConfig
            // 
            this.btnDeleteConfig.Location = new System.Drawing.Point(15, 424);
            this.btnDeleteConfig.Name = "btnDeleteConfig";
            this.btnDeleteConfig.Size = new System.Drawing.Size(190, 23);
            this.btnDeleteConfig.TabIndex = 15;
            this.btnDeleteConfig.Text = "Supprimer la configuration";
            this.btnDeleteConfig.UseVisualStyleBackColor = true;
            this.btnDeleteConfig.Click += new System.EventHandler(this.btnDeleteConfig_Click);
            // 
            // btnModifyConfig
            // 
            this.btnModifyConfig.Location = new System.Drawing.Point(15, 381);
            this.btnModifyConfig.Name = "btnModifyConfig";
            this.btnModifyConfig.Size = new System.Drawing.Size(190, 23);
            this.btnModifyConfig.TabIndex = 16;
            this.btnModifyConfig.Text = "Modifier la configuration";
            this.btnModifyConfig.UseVisualStyleBackColor = true;
            this.btnModifyConfig.Click += new System.EventHandler(this.btnModifyConfig_Click);
            // 
            // btnLauchEmulator
            // 
            this.btnLauchEmulator.Location = new System.Drawing.Point(211, 424);
            this.btnLauchEmulator.Name = "btnLauchEmulator";
            this.btnLauchEmulator.Size = new System.Drawing.Size(211, 23);
            this.btnLauchEmulator.TabIndex = 17;
            this.btnLauchEmulator.Text = "Lancer l\'émulateur";
            this.btnLauchEmulator.UseVisualStyleBackColor = true;
            this.btnLauchEmulator.Click += new System.EventHandler(this.btnLauchEmulator_Click);
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.SystemColors.Control;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.toolStripMenuItem1});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(436, 24);
            this.msMain.TabIndex = 18;
            this.msMain.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 456);
            this.Controls.Add(this.btnLauchEmulator);
            this.Controls.Add(this.btnModifyConfig);
            this.Controls.Add(this.btnDeleteConfig);
            this.Controls.Add(this.btnAddConfig);
            this.Controls.Add(this.tbxCustomConfigName);
            this.Controls.Add(this.lblNbCol);
            this.Controls.Add(this.gbFormat);
            this.Controls.Add(this.tbxWindowURL);
            this.Controls.Add(this.cbxConfig);
            this.Controls.Add(this.lblCustomConfigName);
            this.Controls.Add(this.lblWindowURL);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmConfig";
            this.Text = "Multiple Browsers Emulator";
            this.gbFormat.ResumeLayout(false);
            this.gbFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label lblWindowURL;
        private System.Windows.Forms.Label lblCustomConfigName;
        private System.Windows.Forms.ComboBox cbxConfig;
        private System.Windows.Forms.TextBox tbxWindowURL;
        private System.Windows.Forms.GroupBox gbFormat;
        private System.Windows.Forms.CheckBox chkZoomBottom;
        private System.Windows.Forms.CheckBox chkZoomLeft;
        private System.Windows.Forms.CheckBox chkZoomRight;
        private System.Windows.Forms.CheckBox chkZoomTop;
        private System.Windows.Forms.ComboBox cbxViewType;
        private System.Windows.Forms.Label lblViewType;
        private System.Windows.Forms.Label lblNbRow;
        private System.Windows.Forms.NumericUpDown nudCol;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.TextBox tbxCustomFormat;
        private System.Windows.Forms.RadioButton rdbCustom;
        private System.Windows.Forms.RadioButton rdbExcel;
        private System.Windows.Forms.RadioButton rdbRowCol;
        private System.Windows.Forms.Label lblNbCol;
        private System.Windows.Forms.TextBox tbxCustomConfigName;
        private System.Windows.Forms.Button btnAddConfig;
        private System.Windows.Forms.Button btnDeleteConfig;
        private System.Windows.Forms.Button btnModifyConfig;
        private System.Windows.Forms.Button btnLauchEmulator;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

