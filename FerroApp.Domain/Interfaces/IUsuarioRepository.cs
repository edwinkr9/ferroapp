﻿using FerroApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FerroApp.Domain.Interfaces
{
   public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuario();
        Task<Usuario> GetUsuario(int id);

        Task AddUsuario(Usuario usuario);

        Task<bool> UpdateUsuario(Usuario usuario);
        Task<bool> DeleteUsuario(int id);
    }
}
