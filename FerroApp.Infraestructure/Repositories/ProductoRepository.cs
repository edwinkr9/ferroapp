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

        public async Task<bool> UpdateProducto(Producto producto)
        {
            var current = await GetProducto(producto.Codigo);
            current.Codigo = producto.Codigo;
            current.Clave = producto.Clave;
            current.Nombre = producto.Nombre;
            current.Marca = producto.Marca;
            current.Categoria = producto.Categoria;
            current.Precio = producto.Precio;
            current.Stock = producto.Stock;
            current.Descripcion = producto.Descripcion;
            current.Image = producto.Image;

            var rowsUpdate = await _context.SaveChangesAsync();
            return rowsUpdate > 0;
        }

        public async Task<bool> DeleteProducto(int id)
        {
            var current = await GetProducto(id);

            _context.Productos.Remove(current);
            var rowsDelete = await _context.SaveChangesAsync();
            return rowsDelete > 0;
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
