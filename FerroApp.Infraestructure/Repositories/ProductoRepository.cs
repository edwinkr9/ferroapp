using FerroApp.Domain.Entities;
using FerroApp.Domain.Interfaces;
using FerroApp.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerroApp.Infraestructure.Repositories
{
   public class ProductoRepository: IProductoRepository
    {
        private readonly FerrAppContext _context;
        public ProductoRepository(FerrAppContext context)
        {
            this._context = context;
        }

        public async Task<Producto> GetProducto(int id)
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(producto => producto.Codigo == id);
            return producto;
        }

        public async Task<IEnumerable<Producto>> GetProducto()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task AddProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
        }


        //public async Task<IEnumerable<Producto>> GetProducto()
        //{
        //    var productos = Enumerable.Range(1, 1).Select(x => new Producto{
        //        Codigo = x,
        //        Nombre = "MARTILLO",
        //        Marca = "SHERLY",
        //        Categoria = "HERRAMIENTA",
        //        Precio = "200"


        //    });
        //await Task.Delay(10);
        //return productos;
        //}
    }
}
