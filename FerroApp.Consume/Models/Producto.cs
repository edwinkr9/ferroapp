using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FerroApp.Consume.Models
{
    public class Producto
    {
        [Required]
        //[RegularExpression("^[1-10000]+$", ErrorMessage = "Solo se aceptan números")]
        //[Remote(action: "VerifyCodigo", controller: "ProductoController")]
        public int Codigo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        //[RegularExpression("^[1-10000]+$", ErrorMessage = "Solo se aceptan números")]
        public string Precio { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Categoria { get; set; }
    }
}
