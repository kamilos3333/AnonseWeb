using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AnonseWeb.Helpers
{
    public class AppConfig
    {
        private static string _imagesAdvertisementPath = ConfigurationManager.AppSettings["AdvertisementFolder"];

        public static string AdvertisementFolderPath
        {
            get
            {
                return _imagesAdvertisementPath;
            }
        }
    }
}