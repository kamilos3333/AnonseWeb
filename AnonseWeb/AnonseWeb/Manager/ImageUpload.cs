using AnonseWeb.Helpers;
using System;
using System.IO;
using System.Web;

namespace AnonseWeb.Manager
{
    public static class ImageUpload
    {
        public static string InsertImage(HttpPostedFileBase upload)
        {
            string fileName = getFileName(upload);
            SaveToPath(upload, fileName);
            return fileName;
        }

        public static void EditImage(HttpPostedFileBase upload, string fileName)
        {
            SaveToPath(upload, fileName);
        }

        private static void SaveToPath(HttpPostedFileBase upload, string fileName)
        {
            var path = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(SetFolderPath()), fileName);
            upload.SaveAs(path);
        }

        private static string getFileName(HttpPostedFileBase upload)
        {
            return Guid.NewGuid() + Path.GetExtension(upload.FileName);
        }

        private static string SetFolderPath()
        {
            return AppConfig.AnnouncementFolderPath;
        }
    }
}