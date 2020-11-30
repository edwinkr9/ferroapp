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
    public class GerenteRepository: IGerenteRepository 
    {
        private readonly FerrAppContext _context;
        public GerenteRepository(FerrAppContext context)
        {
            this._context = context;
        }

        public async Task<Gerente> GetGerente(int id)
        {
            var gerente = await _context.Gerentes.FirstOrDefaultAsync(gerente => gerente.IdGerente == id);
            return gerente;
        }

        public async Task<IEnumerable<Gerente>> GetGerente()
        {
            return await _context.Gerentes.ToListAsync();
        }

        public async Task AddGerente(Gerente gerente)
        {
            _context.Gerentes.Add(gerente);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateGerente(Gerente gerente)
        {
            var current = await GetGerente(gerente.IdGerente);
            current.IdGerente = gerente.IdGerente;
            current.Nombres = gerente.Nombres;
            current.ApellidoPaterno = gerente.ApellidoPaterno;
            current.ApellidoMaterno = gerente.ApellidoMaterno;

            var rowsUpdate = await _context.SaveChangesAsync();
            return rowsUpdate > 0;
        }

        public async Task<bool> DeleteGerente(int id)
        {
            var current = await GetGerente(id);

            _context.Gerentes.Remove(current);
            var rowsDelete = await _context.SaveChangesAsync();
            return rowsDelete > 0;
        }
    }
}
