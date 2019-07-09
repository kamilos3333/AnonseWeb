using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AnonseWeb.Data.ApplicationDbContext;

namespace AnonseWeb.Model
{
    public class Advertisement
    {
        [Key]
        public int AdvertisementId { get; set; }
        public string AdvertisementName { get; set; }
        public string Description { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string Status { get; set; }
        public int Visitor { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public string Id { get; set; }
        public int Cost { get; set; }

        public virtual Category categories { get; set; }
        public virtual City cities { get; set; }
        public ApplicationUser users { get; set; }
        public virtual ICollection<File> files { get; set; }
    }
}
