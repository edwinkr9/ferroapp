using FerroApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FerroApp.Domain.Interfaces
{
    public interface IGerenteRepository
    {
        Task<IEnumerable<Gerente>> GetGerente();
        Task<Gerente> GetGerente(int id);

        Task AddGerente(Gerente gerente);

        Task<bool> UpdateGerente(Gerente gerente);
        Task<bool> DeleteGerente(int id);
    }
}
