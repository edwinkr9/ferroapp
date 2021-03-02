using System;
using System.Collections.Generic;

#nullable disable

namespace FerroApp.Domain.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            //Administradors = new HashSet<Administrador>();
            Clientes = new HashSet<Cliente>();
            Gerentes = new HashSet<Gerente>();
        }

        public int IdUsuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        //public virtual ICollection<Administrador> Administradors { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Gerente> Gerentes { get; set; }
    }
}
