using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBE
{
    public partial class frmView : Form
    {
        private frmConfig _frmConfig;
        private Config _config;

        public frmView(frmConfig frmConfig, Config config)
        {
            InitializeComponent();

            FrmConfig = frmConfig;
            Config = config;
        }

        private frmConfig FrmConfig { get => _frmConfig; set => _frmConfig = value; }
        public Config Config { get => _config; set => _config = value; }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmConfig.Show();
        }
        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.ShowDialog();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();

        }

        private void StartEmulator()
        {

        }

        private void frmView_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmConfig.Show();
        }
    }
}
