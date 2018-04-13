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
    [Serializable]
    /// <summary>
    /// Contains datas for emulate devices
    /// </summary>
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

        public Config()
        {

        }

        /// <summary>
        /// Initialize a new config
        /// </summary>
        /// <param name="confName">The name of the config</param>
        /// <param name="url">The url of the config</param>
        /// <param name="paramUrl">The parameter for the url of the config</param>
        /// <param name="row">The number of WebBrowser per row</param>
        /// <param name="col">The number of WebBrowser per column</param>
        /// <param name="zoomTop">Indicate the row of the top has additionnal WebBrowser for zoom effect</param>
        /// <param name="zoomRight">Indicate the column of the right has additionnal WebBrowser for zoom effect</param>
        /// <param name="zoomBottom">Indicate the row of the bottom has additionnal WebBrowser for zoom effect</param>
        /// <param name="zoomLeft">Indicate the column of the left has additionnal WebBrowser for zoom effect</param>
        public Config(string configName, string url, string paramUrl, int row, int col, bool zoomTop = DEFAULT_ZOOM, bool zoomRight = DEFAULT_ZOOM, bool zoomLeft = DEFAULT_ZOOM, bool zoomBottom = DEFAULT_ZOOM)
        {
            ConfigName = configName;
            Url = url;
            ParamUrl = paramUrl;
            Row = row;
            Col = col;
            ZoomTop = zoomTop;
            ZoomRight = zoomRight;
            ZoomLeft = zoomLeft;
            ZoomBottom = zoomBottom;
        }

        /// <summary>
        /// The name of the config
        /// </summary>
        public string ConfigName { get => _configName; set => _configName = value; }
        /// <summary>
        /// The url of the config
        /// </summary>
        public string Url { get => _url; set => _url = value; }
        /// <summary>
        /// The parameter for the url of the config
        /// </summary>
        public string ParamUrl { get => _paramUrl; set => _paramUrl = value; }
        /// <summary>
        /// The number of WebBrowser per row
        /// </summary>
        public int Row { get => _row; set => _row = value; }
        /// <summary>
        /// The number of WebBrowser per column
        /// </summary>
        public int Col { get => _col; set => _col = value; }
        /// <summary>
        /// Indicate the row of the top has additionnal WebBrowser for zoom effect
        /// </summary>
        public bool ZoomTop { get => _zoomTop; set => _zoomTop = value; }
        /// <summary>
        /// Indicate the column of the right has additionnal WebBrowser for zoom effect
        /// </summary>
        public bool ZoomRight { get => _zoomRight; set => _zoomRight = value; }
        /// <summary>
        /// Indicate the row of the bottom has additionnal WebBrowser for zoom effect
        /// </summary>
        public bool ZoomBottom { get => _zoomBottom; set => _zoomBottom = value; }
        /// <summary>
        /// Indicate the column of the left has additionnal WebBrowser for zoom effect
        /// </summary>
        public bool ZoomLeft { get => _zoomLeft; set => _zoomLeft = value; }

    }
}
