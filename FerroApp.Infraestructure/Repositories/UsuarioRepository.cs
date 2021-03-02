using FerroApp.Domain.Entities;
using FerroApp.Domain.Interfaces;
using FerroApp.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FerroApp.Infraestructure.Repositories
{
   public class UsuarioRepository : IUsuarioRepository
    {
        private readonly FerrAppContext _context;
        public UsuarioRepository(FerrAppContext context)
        {
            this._context = context;
        }

        public async Task AddUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteUsuario(int id)
        {
            var current = await GetUsuario(id);

            _context.Usuarios.Remove(current);
            var rowsDelete = await _context.SaveChangesAsync();
            return rowsDelete > 0;
        }

        public async Task<IEnumerable<Usuario>> GetUsuario()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetUsuario(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(usuario => usuario.IdUsuario == id);
            return usuario;
        }

        public async Task<bool> UpdateUsuario(Usuario usuario)
        {
            var current = await GetUsuario(usuario.IdUsuario);
            current.IdUsuario = usuario.IdUsuario;
            current.Correo = usuario.Correo;
            current.Contraseña = usuario.Contraseña;

            var rowsUpdate = await _context.SaveChangesAsync();
            return rowsUpdate > 0;
        }
    }
}
