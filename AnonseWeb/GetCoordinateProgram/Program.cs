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
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Krosno");
            list.Add("Rzeszów");
            list.Add("Warszawa");
            list.Add("Poznań");
            list.Add("Białystok");
            list.Add("Kraków");
            list.Add("Wrocław");
            list.Add("Gdańsk");

            foreach (var item in list)
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                client.Headers.Add("Referer", "http://www.microsoft.com");
                string url = client.DownloadString("https://nominatim.openstreetmap.org/?format=json&addressdetails=1&q=" + item + "&format=json&limit=1");
                dynamic obj = JsonConvert.DeserializeObject<dynamic>(url);

                var lat = obj[0].lat;
                var lon = obj[0].lon;
                Console.WriteLine("{0}: {1} {2}", item, lat, lon);
            }


            Console.ReadKey();
        }
    }
}
