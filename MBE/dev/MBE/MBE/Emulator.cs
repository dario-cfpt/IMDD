/* 
 * Author : Genga Dario & Loureiro Ronaldo
 * Date : 16.03.18
 * Description : Class Emulator
 * Version : 1.0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBE
{
    /// <summary>
    /// Manage the configurations of the application
    /// </summary>
    public class Emulator
    {
        private Config _currentConfig;
        private List<Config> _listConfig;

        /// <summary>
        /// Initialize the Emulator by creating a new config
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
        public Emulator(string configName, string url, string paramUrl, int row, int col, bool zoomTop, bool zoomRight, bool zoomLeft, bool zoomBottom)
        {
            ListConfig = new List<Config>();
            CurrentConfig = CreateConfig(configName, url, paramUrl, row, col, zoomTop, zoomRight, zoomLeft, zoomBottom);      
        }
        /// <summary>
        /// The current config used
        /// </summary>
        public Config CurrentConfig { get => _currentConfig; private set => _currentConfig = value; }

        /// <summary>
        /// Contains all config
        /// </summary>
        public List<Config> ListConfig { get => _listConfig; private set => _listConfig = value; }

        /// <summary>
        /// Create a config
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
        /// <returns>The created config</returns>
        public Config CreateConfig(string confName, string url, string paramUrl, int row , int col, bool zoomTop = Config.DEFAULT_ZOOM, bool zoomRight = Config.DEFAULT_ZOOM, bool zoomBottom = Config.DEFAULT_ZOOM, bool zoomLeft = Config.DEFAULT_ZOOM)
        {
            Config newConfig = new Config(confName, url, paramUrl, row, col, zoomTop, zoomRight, zoomLeft, zoomBottom);
            ListConfig.Add(newConfig);
            CurrentConfig = newConfig;
            return newConfig;
        }

        /// <summary>
        /// Update a config
        /// </summary>
        /// <param name="config">The config to edit</param>
        /// <param name="confName">The name of the config</param>
        /// <param name="url">The url of the config</param>
        /// <param name="paramUrl">The parameter for the url of the config</param>
        /// <param name="row">The number of WebBrowser per row</param>
        /// <param name="col">The number of WebBrowser per column</param>
        /// <param name="zoomTop">Indicate the row of the top has additionnal WebBrowser for zoom effect</param>
        /// <param name="zoomRight">Indicate the column of the right has additionnal WebBrowser for zoom effect</param>
        /// <param name="zoomBottom">Indicate the row of the bottom has additionnal WebBrowser for zoom effect</param>
        /// <param name="zoomLeft">Indicate the column of the left has additionnal WebBrowser for zoom effect</param>
        /// <returns>The updated config</returns>
        public Config UpdateConfig(Config config, string confName, string url, string paramUrl, int row, int col, bool zoomTop = Config.DEFAULT_ZOOM, bool zoomRight = Config.DEFAULT_ZOOM, bool zoomBottom = Config.DEFAULT_ZOOM, bool zoomLeft = Config.DEFAULT_ZOOM)
        {
            config = new Config(confName, url, paramUrl, row, col, zoomTop, zoomRight, zoomLeft, zoomBottom);
            return config;
        }

        /// <summary>
        /// Delete the config passed as parameter
        /// </summary>
        /// <param name="config">The config to delete</param>
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
