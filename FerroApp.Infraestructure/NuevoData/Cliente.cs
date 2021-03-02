using System;
using System.Collections.Generic;

#nullable disable

namespace FerroApp.Api.NuevoData
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string Cp { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
