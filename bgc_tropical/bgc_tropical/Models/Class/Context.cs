using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace bgc_tropical.Models.Class
{
    public class Context: DbContext
    {
        public DbSet<login> logins { get; set; }
        public DbSet<register> registers { get; set; }

    }
}