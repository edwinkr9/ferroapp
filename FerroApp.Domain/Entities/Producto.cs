using System;
using System.Collections.Generic;

#nullable disable

namespace FerroApp.Domain.Entities
{
    public partial class Producto
    {
        public Producto()
        {
            CarritoCompras = new HashSet<CarritoCompra>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }

        public virtual ICollection<CarritoCompra> CarritoCompras { get; set; }
    }
}
