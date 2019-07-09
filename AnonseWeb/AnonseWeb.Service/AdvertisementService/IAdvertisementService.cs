using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonseWeb.Service.AnnouncementService
{
    public interface IAdvertisementService
    {
        IList<City> getAllCity();
        IList<Category> getAllCategory();
        IList<Advertisement> getAllAdvertisement();
        IList<Advertisement> advertisementForClient();
        IList<Advertisement> getUserAdvertisement(string id);
        Advertisement getAdvertisementId(int id);
        void deleteAdvertisement(Advertisement advertisement);
        void editAdvertisement(Advertisement advertisement);
        void insertAdvertisement(Advertisement advertisement);
        void insertFile(File file);
        void save();
    }
}
