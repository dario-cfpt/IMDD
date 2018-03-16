using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBE
{
    public class Emulator
    {
        private Config _currentConfig;
        private List<Config> _listConfig;

        public Emulator(string configName, string url, string paramUrl, int row, int col, bool zoomTop, bool zoomRight, bool zoomLeft, bool zoomBottom)
        {
            CurrentConfig = new Config(configName, url, paramUrl, row, col, zoomTop, zoomRight, zoomLeft, zoomBottom);
            ListConfig = new List<Config>();
        }

        public Config CurrentConfig { get => _currentConfig; private set => _currentConfig = value; }
        public List<Config> ListConfig { get => _listConfig; private set => _listConfig = value; }

        public Config CreateConfig(string confName, string url, string paramUrl, int row , int col, bool zoomTop = Config.DEFAULT_ZOOM, bool zoomRight = Config.DEFAULT_ZOOM, bool zoomBottom = Config.DEFAULT_ZOOM, bool zoomLeft = Config.DEFAULT_ZOOM)
        {
            Config newConfig = new Config(confName, url, paramUrl, row, col, zoomTop, zoomRight, zoomLeft, zoomBottom);
            ListConfig.Add(newConfig);
            CurrentConfig = newConfig;
            return newConfig;
        }

        public Config UpdateConfig(Config config, string confName, string url, string paramUrl, int row, int col, bool zoomTop = Config.DEFAULT_ZOOM, bool zoomRight = Config.DEFAULT_ZOOM, bool zoomBottom = Config.DEFAULT_ZOOM, bool zoomLeft = Config.DEFAULT_ZOOM)
        {
            config = new Config(confName, url, paramUrl, row, col, zoomTop, zoomRight, zoomLeft, zoomBottom);
            return config;
        }

        public void DeleteConfig(Config config)
        {
            ListConfig.Remove(config);
            if (CurrentConfig == config)
            {
                CurrentConfig = null;
                try
                {
                    CurrentConfig = ListConfig.First();
                }
                catch (Exception)
                {
                    CurrentConfig = null;
                }
            }
            config = null;
        }

        /// <summary>
        /// Change current config
        /// </summary>
        /// <param name="config">The new current config</param>
        public void ChangeCurrentConfig(Config config)
        {
            CurrentConfig = config;
        }

    }
}
