﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Domain.DTOs
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