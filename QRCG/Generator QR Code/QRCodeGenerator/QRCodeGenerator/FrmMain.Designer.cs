namespace QRCodeGenerator
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblText = new System.Windows.Forms.Label();
            this.tbxLink = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.doc = new System.Drawing.Printing.PrintDocument();
            this.gbxFormat = new System.Windows.Forms.GroupBox();
            this.lblFullLink = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCol = new System.Windows.Forms.NumericUpDown();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.rdbRowCol = new System.Windows.Forms.RadioButton();
            this.gbxImport = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.gbxPdf = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.gbxFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            this.gbxImport.SuspendLayout();
            this.gbxPdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 14);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(27, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Lien";
            // 
            // tbxLink
            // 
            this.tbxLink.Location = new System.Drawing.Point(45, 11);
            this.tbxLink.Name = "tbxLink";
            this.tbxLink.Size = new System.Drawing.Size(213, 20);
            this.tbxLink.TabIndex = 2;
            this.tbxLink.Text = "http://imdd.ch";
            this.tbxLink.TextChanged += new System.EventHandler(this.tbxLink_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(175, 282);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Générer le QR Code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(150, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 24);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Sauvegarder en PDF";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // doc
            // 
            this.doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.doc_PrintPage);
            // 
            // gbxFormat
            // 
            this.gbxFormat.Controls.Add(this.lblFullLink);
            this.gbxFormat.Controls.Add(this.label3);
            this.gbxFormat.Controls.Add(this.label2);
            this.gbxFormat.Controls.Add(this.label1);
            this.gbxFormat.Controls.Add(this.nudCol);
            this.gbxFormat.Controls.Add(this.nudRow);
            this.gbxFormat.Controls.Add(this.rdbRowCol);
            this.gbxFormat.Location = new System.Drawing.Point(15, 52);
            this.gbxFormat.Name = "gbxFormat";
            this.gbxFormat.Size = new System.Drawing.Size(441, 118);
            this.gbxFormat.TabIndex = 5;
            this.gbxFormat.TabStop = false;
            this.gbxFormat.Text = "Format";
            // 
            // lblFullLink
            // 
            this.lblFullLink.AutoSize = true;
            this.lblFullLink.Location = new System.Drawing.Point(115, 89);
            this.lblFullLink.Name = "lblFullLink";
            this.lblFullLink.Size = new System.Drawing.Size(0, 13);
            this.lblFullLink.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aperçu du lien :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NbCol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NbLignes";
            // 
            // nudCol
            // 
            this.nudCol.Enabled = false;
            this.nudCol.Location = new System.Drawing.Point(380, 42);
            this.nudCol.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCol.Name = "nudCol";
            this.nudCol.Size = new System.Drawing.Size(36, 20);
            this.nudCol.TabIndex = 2;
            this.nudCol.ValueChanged += new System.EventHandler(this.nudRowAndCol_ValueChanged);
            // 
            // nudRow
            // 
            this.nudRow.Enabled = false;
            this.nudRow.Location = new System.Drawing.Point(241, 42);
            this.nudRow.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(36, 20);
            this.nudRow.TabIndex = 1;
            this.nudRow.ValueChanged += new System.EventHandler(this.nudRowAndCol_ValueChanged);
            // 
            // rdbRowCol
            // 
            this.rdbRowCol.AutoSize = true;
            this.rdbRowCol.Location = new System.Drawing.Point(30, 42);
            this.rdbRowCol.Name = "rdbRowCol";
            this.rdbRowCol.Size = new System.Drawing.Size(105, 17);
            this.rdbRowCol.TabIndex = 0;
            this.rdbRowCol.TabStop = true;
            this.rdbRowCol.Text = "Lignes/Colonnes";
            this.rdbRowCol.UseVisualStyleBackColor = true;
            this.rdbRowCol.CheckedChanged += new System.EventHandler(this.rdbRowCol_CheckedChanged);
            // 
            // gbxImport
            // 
            this.gbxImport.Controls.Add(this.btnImport);
            this.gbxImport.Enabled = false;
            this.gbxImport.Location = new System.Drawing.Point(15, 176);
            this.gbxImport.Name = "gbxImport";
            this.gbxImport.Size = new System.Drawing.Size(441, 89);
            this.gbxImport.TabIndex = 6;
            this.gbxImport.TabStop = false;
            this.gbxImport.Text = "Importation";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(134, 38);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(166, 32);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Importe un fichier CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gbxPdf
            // 
            this.gbxPdf.Controls.Add(this.btnSave);
            this.gbxPdf.Location = new System.Drawing.Point(15, 319);
            this.gbxPdf.Name = "gbxPdf";
            this.gbxPdf.Size = new System.Drawing.Size(441, 114);
            this.gbxPdf.TabIndex = 7;
            this.gbxPdf.TabStop = false;
            this.gbxPdf.Text = "PDF";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(477, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(478, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 300);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(478, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 300);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(477, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(300, 300);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(478, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(300, 300);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(478, 14);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(300, 300);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(478, 14);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(300, 300);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(478, 14);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(300, 300);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRCode.TabIndex = 16;
            this.pbQRCode.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(478, 14);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(300, 300);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 5;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 454);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.gbxPdf);
            this.Controls.Add(this.gbxImport);
            this.Controls.Add(this.gbxFormat);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbxLink);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Générateur de QR Code";
            this.gbxFormat.ResumeLayout(false);
            this.gbxFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            this.gbxImport.ResumeLayout(false);
            this.gbxPdf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbxLink;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSave;
        private System.Drawing.Printing.PrintDocument doc;
        private System.Windows.Forms.GroupBox gbxFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCol;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.RadioButton rdbRowCol;
        private System.Windows.Forms.GroupBox gbxImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox gbxPdf;
        private System.Windows.Forms.Label lblFullLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

