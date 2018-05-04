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
    class QRController
    {
        QRCode qr = new QRCode();

        internal QRCode Qr { get => qr; set => qr = value; }

        public List<Image> QRCodeGen(string link, decimal row, decimal col)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            link = "www.imdd.ch/";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Qr.LinkList.Add("Row="+(i+1)+";"+"Col="+(j+1));
                }
            }

            foreach (string item in Qr.LinkList)
            {
                Qr.ListImage.Add(qrcode.Draw(link + item, 50));
            }
            return Qr.ListImage;
        }
        public void PrintList(System.Drawing.Printing.PrintPageEventArgs e)
        {
            foreach (var item in Qr.ListImage)
            {
                Bitmap bm = new Bitmap(item.Width,item.Height);
                e.Graphics.DrawImage(bm,0,0);
                bm.Dispose();
            }
        }
        public void DisplayPB(PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, PictureBox pb6, PictureBox pb7, PictureBox pb8, PictureBox pb9)
        {
            pb1.Image = Qr.ListImage[0];
            pb2.Image = Qr.ListImage[1];
            pb3.Image = Qr.ListImage[2];
            pb4.Image = Qr.ListImage[3];
            pb5.Image = Qr.ListImage[4];
            pb6.Image = Qr.ListImage[5];
            pb7.Image = Qr.ListImage[6];
            pb8.Image = Qr.ListImage[7];
            pb9.Image = Qr.ListImage[8];
        }
    }
}
