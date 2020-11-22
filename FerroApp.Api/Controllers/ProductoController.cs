using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FerroApp.Domain.Entities;
using FerroApp.Domain.Interfaces;
using FerroApp.Infraestructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FerroApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _repository;
        public ProductoController(IProductoRepository repository)
        {
            this._repository = repository;
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var producto = await _repository.GetProducto(id);
            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Producto producto)
        {
            await _repository.AddProducto(producto);
            return Ok(producto);
        }
    }
}
