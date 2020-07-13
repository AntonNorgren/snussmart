using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SnusSmartAPI.Models
{
    public class Snuff
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int BrandID { get; set; }
        public int PouchTypeID { get; set; }
        public int SizeID { get; set; }

    }
}
