using FerroApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FerroApp.Domain.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetProducto();
        Task<Producto> GetProducto(int id);

        Task AddProducto(Producto producto);

        Task<bool> UpdateProducto(Producto producto);
        Task<bool> DeleteProducto(int id);


    }
}
