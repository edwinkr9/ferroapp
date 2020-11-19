using System;
using System.Collections.Generic;

#nullable disable

namespace FerroApp.Domain.Entities
{
    public partial class CarritoCompra
    {
        public int IdCarrito { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public string DireccionCliente { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string PagoTotal { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
