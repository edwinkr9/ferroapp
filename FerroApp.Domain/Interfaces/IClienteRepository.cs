using FerroApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FerroApp.Domain.Interfaces
{
   public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetCliente();
        Task<Cliente> GetCliente(int id);

        Task AddCliente(Cliente cliente);

        Task<bool> UpdateCliente(Cliente cliente);
        Task<bool> DeleteCliente(int id);
    }
}
