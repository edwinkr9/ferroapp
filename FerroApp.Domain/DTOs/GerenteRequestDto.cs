using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Domain.DTOs
{
   public class GerenteRequestDto
    {
        //public int IdGerente { get; set; }
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
    }
}
