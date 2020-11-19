using System;
using System.Collections.Generic;

#nullable disable

namespace FerroApp.Domain.Entities
{
    public partial class Gerente
    {
        public int IdGerente { get; set; }
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
