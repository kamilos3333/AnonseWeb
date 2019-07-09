using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonseWeb.Model
{
    public class File
    {
        [Key]
        public int FileId { get; set; }
        public string FileName { get; set; }
        public int AdvertisementId { get; set; }

        public virtual Advertisement advertisements { get; set; }
    }
}
