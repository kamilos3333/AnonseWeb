using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AnonseWeb.Helpers
{
    public class AppConfig
    {
        private static string _imagesAnnouncementPath = ConfigurationManager.AppSettings["AnnouncementFolder"];

        public static string AnnouncementFolderPath
        {
            get
            {
                return _imagesAnnouncementPath;
            }
        }
    }
}