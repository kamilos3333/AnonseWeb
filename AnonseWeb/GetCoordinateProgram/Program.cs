using AnonseWeb.Data;
using AnonseWeb.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetCoordinateProgram
{
    class Program
    {
        private static ApplicationDbContext db = new ApplicationDbContext();

        static void Main(string[] args)
        {
            foreach (var item in getDataElement())
            {
                WebClient client = WebClientHeader();
                string url = DownloadString(item, client);
                dynamic lat, lon;
                ConvertJson(url, out lat, out lon);
                getItemFromBase(item, lat, lon);

                Console.WriteLine("{0}: {1} {2}", item.CityName, lat, lon);
            }
            Console.WriteLine("Zakończono pomyślnie");
            Console.ReadKey();
        }

        private static WebClient WebClientHeader()
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            client.Headers.Add("Referer", "http://www.microsoft.com");
            return client;
        }

        private static string DownloadString(City item, WebClient client)
        {
            return client.DownloadString("https://nominatim.openstreetmap.org/?format=json&addressdetails=1&q=" + item.CityName + "&format=json&limit=1");
        }

        private static void ConvertJson(string url, out dynamic lat, out dynamic lon)
        {
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(url);

            lat = Convert.ToDouble(obj[0].lat);
            lon = Convert.ToDouble(obj[0].lon);
        }

        private static void getItemFromBase(City item, dynamic lat, dynamic lon)
        {
            var getElementFromBase = db.Cities.FirstOrDefault(a => a.CityName.Contains(item.CityName));
            getElementFromBase.lat = lat;
            getElementFromBase.lon = lon;
            SaveToBase();
        }

        private static void SaveToBase()
        {
            db.SaveChanges();
        }

        private static List<City> getDataElement()
        {
            var list = db.Cities.ToList();
            return list;
        }
    }
}
    

