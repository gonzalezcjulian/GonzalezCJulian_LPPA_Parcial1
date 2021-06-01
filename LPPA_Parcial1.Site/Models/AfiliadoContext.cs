using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LPPA_Parcial1.Site.Models
{
    public class AfiliadoContext : DbContext
    {
        public AfiliadoContext()
            :base("DefaultConnection")
        {

        }
        public DbSet<Afiliado> Afiliados { get; set; }
    }
}