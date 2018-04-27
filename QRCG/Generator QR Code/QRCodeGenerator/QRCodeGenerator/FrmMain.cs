using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfFileWriter;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace QRCodeGenerator
{
    public partial class FrmMain : Form
    {
        QRController controller = new QRController();
        PrintDialog pd = new PrintDialog();
        int pageBreak = 0;

        public FrmMain()
        {
            InitializeComponent();
            doc.PrintPage += doc_PrintPage;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            if (lblFullLink.Text != "")
            {
                List<Image> list = controller.QRCodeGen(lblFullLink.Text, nudRow.Value, nudCol.Value);
                btnSave.Enabled = true;
                controller.DisplayPB(pbQRCode, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Voulez vous vraiment générer le QRCode avec le lien sans paramètre ?", "Attention !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    pbQRCode.Image = qrcode.Draw(tbxLink.Text, 50);
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
                if (pbQRCode.Image == null)
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }
            }

        }

        private void tbxLink_TextChanged(object sender, EventArgs e)
        {
            if (tbxLink.Text != "")
            {
                btnGenerate.Enabled = true;
            }
            else
            {
                btnGenerate.Enabled = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pd.Document = doc;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                pageBreak = 0;
                doc.Print();
            }
        }

        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (pageBreak < controller.Qr.ListImage.Count())
            {
                Bitmap bm = new Bitmap(controller.Qr.ListImage[pageBreak], pbQRCode.Width, pbQRCode.Height);
                int hascode = controller.Qr.ListImage[pageBreak].GetHashCode();
                e.Graphics.DrawImage(bm, 0, 0);
                pageBreak++;

                e.HasMorePages = true;
            }
        }

        private void rdbRowCol_CheckedChanged(object sender, EventArgs e)
        {
            nudCol.Enabled = true;
            nudRow.Enabled = true;
            btnImport.Enabled = false;
        }


        private void nudRowAndCol_ValueChanged(object sender, EventArgs e)
        {
            int nbRow = (int)nudRow.Value;
            int nbCol = (int)nudCol.Value;
            string parameterLink = "/Lignes=" + nbRow + ";Colonnes=" + nbCol;
            lblFullLink.Text = tbxLink.Text + parameterLink;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File";
            theDialog.Filter = "CSV files|*.csv";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            MessageBox.Show("Bravo");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
