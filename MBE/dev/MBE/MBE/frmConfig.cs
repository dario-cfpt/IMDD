﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MBE
{
    public partial class frmConfig : Form
    {
        private List<Config> _listConfig;
        private Config _morpion;
        private Config _currentConfig;
      

        public List<Config> ListConfig { get => _listConfig; set => _listConfig = value; }
        public Config Morpion { get => _morpion; set => _morpion = value; }
        public Config CurrentConfig { get => _currentConfig; set => _currentConfig = value; }

        public frmConfig()
        {
            InitializeComponent();

            ListConfig = new List<Config>();
            Morpion = new Config("Morpion", "http://10.134.97.39/php/imdd.php", "id", 3, 3); // Configuration for TicTacToe

            ListConfig.Add(Morpion);
            foreach (Config configuration in ListConfig)
            {
                cbxConfig.Items.Add(configuration.ConfigName);
            }
            rdbRowCol.Checked = true;
            cbxConfig.SelectedIndex = 0;
        }

        /// <summary>
        /// This function add an configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndexConfig = cbxConfig.SelectedIndex;
                string url = tbxWindowURL.Text;
                string paramURL = "";
                int row = Convert.ToInt32(nudRow.Value);
                int col = Convert.ToInt32(nudCol.Value);
                bool zoomTop = false;
                bool zoomBottom = false;
                bool zoomLeft = false;
                bool zoomRight = false;
                bool urlParamColRow, urlParamExcel, urlParamCustom;
                string configurationName = tbxCustomConfigName.Text;

                if (rdbRowCol.Checked)
                {
                    urlParamColRow = true;
                    paramURL = "id";
                }
                if (rdbExcel.Checked)
                {
                    urlParamExcel = true;
                    paramURL = "A/1";

                }
                if (rdbCustom.Checked)
                {
                    urlParamCustom = true;
                    paramURL = tbxCustomFormat.Text;
                }

                if (chkZoomTop.Checked)
                {
                    zoomTop = true;
                }
                if (chkZoomRight.Checked)
                {
                    zoomRight = true;
                }
                if (chkZoomLeft.Checked)
                {
                    zoomLeft = true;
                }
                if (chkZoomRight.Checked)
                {
                    zoomRight = true;
                }

                if (tbxCustomConfigName.Text == "")
                {
                    configurationName = "ConfigPerso" + cbxConfig.Items.Count;
                }

                Emulator.GetIntance().CreateConfig(configurationName, url, paramURL, row, col, zoomTop, zoomRight, zoomBottom, zoomLeft);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifyConfig_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This function launch the emulator with the current configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLauchEmulator_Click(object sender, EventArgs e)
        {
            frmView view = new frmView(this, CurrentConfig);
            view.Show();
            this.Hide();
        }

        /// <summary>
        /// This function delete the selected configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteConfig_Click(object sender, EventArgs e)
        {

        }

        private void tbxWindowURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// When the index change we reatribute the current configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentConfig = ListConfig[cbxConfig.SelectedIndex];
                string name = "";
                cbxViewType.SelectedIndex = 0;
                tbxCustomFormat.Enabled = false;
                nudCol.Value = CurrentConfig.Col;
                nudRow.Value = CurrentConfig.Row;
                // cbxConfig.Items.Add(ListConfig.Select(c => c.ConfigName == Morpion.ConfigName).ToArray()[0]);
                tbxWindowURL.Text = Morpion.Url;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxViewType.SelectedItem)
            {
                case "Standard":
                    chkZoomTop.Enabled = false;
                    chkZoomRight.Enabled = false;
                    chkZoomBottom.Enabled = false;
                    chkZoomLeft.Enabled = false;

                    chkZoomTop.Checked = false;
                    chkZoomRight.Checked = false;
                    chkZoomBottom.Checked = false;
                    chkZoomLeft.Checked = false;

                    break;
                case "Zoomé":
                    chkZoomTop.Enabled = true;
                    chkZoomRight.Enabled = true;
                    chkZoomBottom.Enabled = true;
                    chkZoomLeft.Enabled = true;
                    break;
                default:
                    chkZoomTop.Enabled = false;
                    chkZoomRight.Enabled = false;
                    chkZoomBottom.Enabled = false;
                    chkZoomLeft.Enabled = false;

                    chkZoomTop.Checked = false;
                    chkZoomRight.Checked = false;
                    chkZoomBottom.Checked = false;
                    chkZoomLeft.Checked = false;

                    break;
            }
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCustom.Checked)
            {
                tbxCustomFormat.Enabled = true;
            }
            else
            {
                tbxCustomFormat.Enabled = false;
                tbxCustomFormat.Text = null;
            }
        }

        private void gbFormat_Enter(object sender, EventArgs e)
        {
            btnAddConfig.Enabled = true;
            tbxCustomConfigName.Enabled = true;
        }

        private void tbxWindowURL_TextChanged(object sender, EventArgs e)
        {
            btnLauchEmulator.Enabled = (tbxWindowURL.Text != "") ? true : false;
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            #region disable component
            gbParam.Enabled = false;
            tbxWindowURL.Enabled = false;
            btnAddConfig.Enabled = false;
            btnDeleteConfig.Enabled = false;
            btnModifyConfig.Enabled = false;
            lblCustomConfigName.Enabled = false;
            #endregion // We disable all the component because the app isn't dynamic
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
