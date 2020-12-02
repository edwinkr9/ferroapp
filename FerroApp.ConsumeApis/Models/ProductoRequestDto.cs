using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerroApp.ConsumeApis.Models
{
    public class ProductoRequestDto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
    }
}