using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Rob_master.Models
{
    public partial class Denuncias
    {
        public int? Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double? Valor { get; set; }
        public string Lugar { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
    }
}
