using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBE
{
    public class Config
    {
        private string _configName;
        private string _url;
        private string _paramUrl;
        private int[,] _arrayWindows;
        private bool _zoomTop;
        private bool _zoomRight;
        private bool _zoomLeft;
        private bool _zoomBottom;

        public Config(string configName, string url, string paramUrl, int[,] arrayWindows, bool zoomTop, bool zoomRight, bool zoomLeft, bool zoomBottom)
        {
            ConfigName = configName;
            Url = url;
            ParamUrl = paramUrl;
            ArrayWindows = arrayWindows;
            ZoomTop = zoomTop;
            ZoomRight = zoomRight;
            ZoomLeft = zoomLeft;
            ZoomBottom = zoomBottom;
        }

        public string ConfigName { get => _configName; set => _configName = value; }
        public string Url { get => _url; set => _url = value; }
        public string ParamUrl { get => _paramUrl; set => _paramUrl = value; }
        public int[,] ArrayWindows { get => _arrayWindows; set => _arrayWindows = value; }
        public bool ZoomTop { get => _zoomTop; set => _zoomTop = value; }
        public bool ZoomRight { get => _zoomRight; set => _zoomRight = value; }
        public bool ZoomLeft { get => _zoomLeft; set => _zoomLeft = value; }
        public bool ZoomBottom { get => _zoomBottom; set => _zoomBottom = value; }
    }
}
