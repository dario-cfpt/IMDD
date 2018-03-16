/* 
 * Author : Genga Dario & Loureiro Ronaldo
 * Date : 09.03.18
 * Description : Class Config
 * Version : 1.0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBE
{
    public class Config
    {
        public const bool DEFAULT_ZOOM = false;

        private string _configName;
        private string _url;
        private string _paramUrl;
        private int _row;
        private int _col;
        private bool _zoomTop;
        private bool _zoomRight;
        private bool _zoomLeft;
        private bool _zoomBottom;

        public Config(string configName, string url, string paramUrl, int row, int col, bool zoomTop = DEFAULT_ZOOM, bool zoomRight = DEFAULT_ZOOM, bool zoomLeft = DEFAULT_ZOOM, bool zoomBottom = DEFAULT_ZOOM)
        {
            ConfigName = configName;
            Url = url;
            ParamUrl = paramUrl;
            ZoomTop = zoomTop;
            ZoomRight = zoomRight;
            ZoomLeft = zoomLeft;
            ZoomBottom = zoomBottom;
        }

        public string ConfigName { get => _configName; set => _configName = value; }
        public string Url { get => _url; set => _url = value; }
        public string ParamUrl { get => _paramUrl; set => _paramUrl = value; }
        public bool ZoomTop { get => _zoomTop; set => _zoomTop = value; }
        public bool ZoomRight { get => _zoomRight; set => _zoomRight = value; }
        public bool ZoomLeft { get => _zoomLeft; set => _zoomLeft = value; }
        public bool ZoomBottom { get => _zoomBottom; set => _zoomBottom = value; }
        public int Row { get => _row; set => _row = value; }
        public int Col { get => _col; set => _col = value; }
    }
}
