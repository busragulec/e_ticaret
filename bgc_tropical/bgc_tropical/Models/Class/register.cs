using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bgc_tropical.Models.Class
{
    public class register
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string mail { get; set; }
        public string sifre { get; set; }
        public string sifretekrar { get; set; }
        public string telefon { get; set; }
        public string dogumtarihi { get; set; }
        public bool optradio { get; set; }
        public int kod { get; set; }
    }
}