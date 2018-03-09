using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBE
{
    public class Emulator
    {
        private Config _config;
        private List<Config> _listConfig;

        public Emulator(string configName, string url, string paramUrl, int[,] arrayWindows, bool zoomTop, bool zoomRight, bool zoomLeft, bool zoomBottom)
        {
            Config = new Config(configName, url, paramUrl, arrayWindows, zoomTop, zoomRight, zoomLeft, zoomBottom);
            ListConfig = new List<Config>();
        }

        public Config Config { get => _config; set => _config = value; }
        public List<Config> ListConfig { get => _listConfig; set => _listConfig = value; }
    }
}
