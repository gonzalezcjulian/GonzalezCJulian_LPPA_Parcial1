using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LPPA_Parcial1.Site.Models
{
    public class Afiliado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string CUIT { get; set; }
    }
}