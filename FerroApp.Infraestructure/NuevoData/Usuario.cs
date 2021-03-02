using System;
using System.Collections.Generic;

#nullable disable

namespace FerroApp.Api.NuevoData
{
    public partial class Usuario
    {
        public Usuario()
        {
            Clientes = new HashSet<Cliente>();
            Gerentes = new HashSet<Gerente>();
        }

        public int IdUsuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Gerente> Gerentes { get; set; }
    }
}
