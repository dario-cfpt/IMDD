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
        private const int SIZE_WB = 235;
        private const int FIRST_LOCATION_ROW_WB = 6;
        private const int FIRST_LOCATION_COL_WB = 19;

        public frmView(frmConfig frmConfig, Config config)
        {
            InitializeComponent();

            FrmConfig = frmConfig;
            Config = config;
            StartEmulator();
        }

        private frmConfig FrmConfig { get => _frmConfig; set => _frmConfig = value; }
        public Config Config { get => _config; set => _config = value; }
            
        /// <summary>
        /// Start the emulator with the Config
        /// </summary>
        private void StartEmulator()
        {
            GenerateMorpionConfig();
        }

        /// <summary>
        /// Generate the url from the Config
        /// <para>
        /// /!\ This method don't work for multiple param /!\
        /// </para>
        /// </summary>
        /// <param name="paramValue">The value of the param of the url</param>
        /// <returns>An Uri object of the url for the WebBrowser</returns>
        private Uri GenerateUrl(int paramValue)
        {
            string url = Config.Url;
            url += "?" + Config.ParamUrl + "=" + paramValue;
            return new Uri(url);
        }

        /// <summary>
        /// Generate the WebBrowser for the morpion config
        /// <para>
        /// Temporary method for generate morpion config.
        /// Need to be adapted for generate others config.
        /// </para>
        /// </summary>
        private void GenerateMorpionConfig()
        {
            int index = 1;

            for (int col = 0; col < Config.Col; col++)
            {
                for (int row = 0; row < Config.Row; row++)
                {
                    WebBrowser wb = new WebBrowser
                    {
                        ScriptErrorsSuppressed = true,
                        Url = GenerateUrl(index),
                        Location = new Point(SIZE_WB * row + FIRST_LOCATION_ROW_WB, SIZE_WB * col + FIRST_LOCATION_COL_WB),
                        Size = new Size(SIZE_WB, SIZE_WB)
                    };
                    index++;
                    pnlEmulator.Controls.Add(wb);
                }
            }
        }

        #region ViewEvents
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

        private void frmView_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmConfig.Show();
        }
        #endregion ViewEvents
    }
}
