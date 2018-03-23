namespace MBE
{
    partial class frmView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbxEmulator = new System.Windows.Forms.GroupBox();
            this.wb1 = new System.Windows.Forms.WebBrowser();
            this.wb6 = new System.Windows.Forms.WebBrowser();
            this.wb3 = new System.Windows.Forms.WebBrowser();
            this.wb4 = new System.Windows.Forms.WebBrowser();
            this.wb5 = new System.Windows.Forms.WebBrowser();
            this.wb2 = new System.Windows.Forms.WebBrowser();
            this.wb7 = new System.Windows.Forms.WebBrowser();
            this.wb8 = new System.Windows.Forms.WebBrowser();
            this.wb9 = new System.Windows.Forms.WebBrowser();
            this.msMain.SuspendLayout();
            this.grpbxEmulator.SuspendLayout();
            this.SuspendLayout();
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
            this.msMain.Size = new System.Drawing.Size(758, 24);
            this.msMain.TabIndex = 19;
            this.msMain.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // grpbxEmulator
            // 
            this.grpbxEmulator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxEmulator.Controls.Add(this.wb9);
            this.grpbxEmulator.Controls.Add(this.wb8);
            this.grpbxEmulator.Controls.Add(this.wb7);
            this.grpbxEmulator.Controls.Add(this.wb2);
            this.grpbxEmulator.Controls.Add(this.wb5);
            this.grpbxEmulator.Controls.Add(this.wb4);
            this.grpbxEmulator.Controls.Add(this.wb3);
            this.grpbxEmulator.Controls.Add(this.wb6);
            this.grpbxEmulator.Controls.Add(this.wb1);
            this.grpbxEmulator.Location = new System.Drawing.Point(12, 43);
            this.grpbxEmulator.Name = "grpbxEmulator";
            this.grpbxEmulator.Size = new System.Drawing.Size(734, 755);
            this.grpbxEmulator.TabIndex = 20;
            this.grpbxEmulator.TabStop = false;
            this.grpbxEmulator.Text = "Écrans fictifs";
            // 
            // wb1
            // 
            this.wb1.Location = new System.Drawing.Point(6, 19);
            this.wb1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb1.Name = "wb1";
            this.wb1.Size = new System.Drawing.Size(235, 235);
            this.wb1.TabIndex = 0;
            this.wb1.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=1", System.UriKind.Absolute);
            // 
            // wb6
            // 
            this.wb6.Location = new System.Drawing.Point(488, 260);
            this.wb6.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb6.Name = "wb6";
            this.wb6.Size = new System.Drawing.Size(235, 235);
            this.wb6.TabIndex = 1;
            this.wb6.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=6", System.UriKind.Absolute);
            // 
            // wb3
            // 
            this.wb3.Location = new System.Drawing.Point(488, 19);
            this.wb3.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb3.Name = "wb3";
            this.wb3.Size = new System.Drawing.Size(235, 235);
            this.wb3.TabIndex = 2;
            this.wb3.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=3", System.UriKind.Absolute);
            // 
            // wb4
            // 
            this.wb4.Location = new System.Drawing.Point(6, 260);
            this.wb4.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb4.Name = "wb4";
            this.wb4.Size = new System.Drawing.Size(235, 235);
            this.wb4.TabIndex = 3;
            this.wb4.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=4", System.UriKind.Absolute);
            // 
            // wb5
            // 
            this.wb5.Location = new System.Drawing.Point(247, 260);
            this.wb5.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb5.Name = "wb5";
            this.wb5.Size = new System.Drawing.Size(235, 235);
            this.wb5.TabIndex = 4;
            this.wb5.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=5", System.UriKind.Absolute);
            // 
            // wb2
            // 
            this.wb2.Location = new System.Drawing.Point(247, 19);
            this.wb2.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb2.Name = "wb2";
            this.wb2.Size = new System.Drawing.Size(235, 235);
            this.wb2.TabIndex = 5;
            this.wb2.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=2", System.UriKind.Absolute);
            // 
            // wb7
            // 
            this.wb7.Location = new System.Drawing.Point(6, 501);
            this.wb7.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb7.Name = "wb7";
            this.wb7.Size = new System.Drawing.Size(235, 235);
            this.wb7.TabIndex = 6;
            this.wb7.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=7", System.UriKind.Absolute);
            // 
            // wb8
            // 
            this.wb8.Location = new System.Drawing.Point(247, 501);
            this.wb8.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb8.Name = "wb8";
            this.wb8.Size = new System.Drawing.Size(235, 235);
            this.wb8.TabIndex = 7;
            this.wb8.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=8", System.UriKind.Absolute);
            // 
            // wb9
            // 
            this.wb9.Location = new System.Drawing.Point(488, 501);
            this.wb9.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb9.Name = "wb9";
            this.wb9.Size = new System.Drawing.Size(235, 235);
            this.wb9.TabIndex = 8;
            this.wb9.Url = new System.Uri("http://10.134.97.39/php/imdd.php?id=9", System.UriKind.Absolute);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 810);
            this.Controls.Add(this.grpbxEmulator);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmView";
            this.Text = "Multiple Browser Emulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmView_FormClosed);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.grpbxEmulator.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpbxEmulator;
        private System.Windows.Forms.WebBrowser wb1;
        private System.Windows.Forms.WebBrowser wb9;
        private System.Windows.Forms.WebBrowser wb8;
        private System.Windows.Forms.WebBrowser wb7;
        private System.Windows.Forms.WebBrowser wb2;
        private System.Windows.Forms.WebBrowser wb5;
        private System.Windows.Forms.WebBrowser wb4;
        private System.Windows.Forms.WebBrowser wb3;
        private System.Windows.Forms.WebBrowser wb6;
    }
}