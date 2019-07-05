using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnonseWeb.Helpers
{
    public static class UrHelpers
    {
        public static string AnnouncementImgPath(this UrlHelper helper, string nameAnnouncementFolder)
        {
            var AnnouncementImgFolder = AppConfig.AnnouncementFolderPath;
            var path = Path.Combine(AnnouncementImgFolder, nameAnnouncementFolder);
            var pathFolder = helper.Content(path);

            return pathFolder;
        }
    }
}