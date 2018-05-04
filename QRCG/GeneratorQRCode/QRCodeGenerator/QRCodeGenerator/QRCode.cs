using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeGenerator
{
    class QRCode
    {
        private List<string> _linkList = new List<string>();
        private List<Image> _listImage = new List<Image>();
        public List<string> LinkList { get => _linkList; set => _linkList = value; }
        public List<Image> ListImage { get => _listImage; set => _listImage = value; }

        public QRCode()
        {

        }
    }
}
