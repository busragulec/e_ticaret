using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bgc_tropical.Models.Class
{
    public class login
    {

        [Key]
        public int id { get; set; }
        public string eposta { get; set; }
        public string sifre { get; set; }
    }
}