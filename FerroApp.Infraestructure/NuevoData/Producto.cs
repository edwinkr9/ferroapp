﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FerroApp.Api.NuevoData
{
    public partial class Producto
    {
        public int Codigo { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Stock { get; set; }
        public string Descripcion { get; set; }
        public string Image { get; set; }
    }
}
