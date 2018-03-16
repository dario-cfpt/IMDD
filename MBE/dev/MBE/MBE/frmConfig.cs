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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();

            rdbRowCol.Checked = true;
            cbxConfig.SelectedIndex = 0;
            cbxViewType.SelectedIndex = 0;
            tbxCustomFormat.Enabled = false;
        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndexConfig = cbxConfig.SelectedIndex;
                string url = tbxWindowURL.Text;
                string paramURL;
                int row = Convert.ToInt32(nudRow.Value);
                int col = Convert.ToInt32(nudCol.Value);
                bool zoomTop, zoomBottom, zoomLeft, zoomRight, urlParamColRow, urlParamExcel, urlParamCustom;
                string configurationName = tbxCustomConfigName.Text;

                if (rdbRowCol.Checked)
                {
                    urlParamColRow = true;
                    paramURL = "row1/col1";
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

            }
            catch (Exception)
            {

            }
        }

        private void btnModifyConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnLauchEmulator_Click(object sender, EventArgs e)
        {

        }

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

        private void cbxConfig_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            } else
            {
                tbxCustomFormat.Enabled = false;
                tbxCustomFormat.Text = null;
            }
        }
    }
}
