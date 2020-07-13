﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SnusSmartAPI.Models
{
    public class Brand
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Slogan { get; set; }
    }
}
