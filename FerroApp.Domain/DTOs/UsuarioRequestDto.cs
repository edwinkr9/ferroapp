﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Domain.DTOs
{
    public class UsuarioRequestDto
    {
        //public int IdUsuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}