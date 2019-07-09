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
        public static string AdvertisementImgPath(this UrlHelper helper, string nameAdvertisementFolder)
        {
            var AdvertisementImgFolder = AppConfig.AdvertisementFolderPath;
            var path = Path.Combine(AdvertisementImgFolder, nameAdvertisementFolder);
            var pathFolder = helper.Content(path);

            return pathFolder;
        }
    }
}