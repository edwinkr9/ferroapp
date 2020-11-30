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
    public class ClienteRepository: IClienteRepository
    {
        private readonly FerrAppContext _context;
        public ClienteRepository(FerrAppContext context)
        {
            this._context = context;
        }

        public async Task<Cliente> GetCliente(int id)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(cliente => cliente.IdCliente == id);
            return cliente;
        }

        public async Task<IEnumerable<Cliente>> GetCliente()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateCliente(Cliente cliente)
        {
            var current = await GetCliente(cliente.IdCliente);
            current.IdCliente = cliente.IdCliente;
            current.Nombres = cliente.Nombres;           
            current.ApellidoPaterno = cliente.ApellidoPaterno;
            current.ApellidoMaterno = cliente.ApellidoMaterno;
            current.Cp = cliente.Cp;
            current.Direccion = cliente.Direccion;

            var rowsUpdate = await _context.SaveChangesAsync();
            return rowsUpdate > 0;
        }

        public async Task<bool> DeleteCliente(int id)
        {
            var current = await GetCliente(id);

            _context.Clientes.Remove(current);
            var rowsDelete = await _context.SaveChangesAsync();
            return rowsDelete > 0;
        }
    }
}
