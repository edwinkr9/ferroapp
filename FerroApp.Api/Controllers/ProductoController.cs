using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FerroApp.Api.Responses;
using FerroApp.Domain.DTOs;
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
        private readonly IMapper _mapper;
       

        //public ProductoController(IProductoRepository repository)
        //{
        //    this._repository = repository;
        //}
        public ProductoController(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            this._mapper = mapper;
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _repository.DeleteProducto(id);
            var response = new ApiResponse<bool>(result);

            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, ProductoRequestDto productoDto)
        {
            var producto = _mapper.Map<Producto>(productoDto); 
            var result = await _repository.UpdateProducto(producto);
            var response = new ApiResponse<bool>(result);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var productos = await _repository.GetProducto();
            var productoDto = _mapper.Map<IEnumerable<Producto>, IEnumerable<ProductoResponseDto>>(productos);
            var response = new ApiResponse<IEnumerable<ProductoResponseDto>>(productoDto);

            return Ok(response);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var producto = await _repository.GetProducto(id);
            //var config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoResponseDto>());
            //var _mapper = new Mapper(config);
            var productoDto = _mapper.Map<Producto, ProductoResponseDto>(producto);
            var response = new ApiResponse<ProductoResponseDto>(productoDto);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductoRequestDto productoDto)
        {
            //var config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoRequestDto>());
            //var _mapper = new Mapper(config);
            var producto = _mapper.Map<ProductoRequestDto, Producto>(productoDto);
            await _repository.AddProducto(producto);

            //config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoResponseDto>());
            //_mapper = new Mapper(config);
            var productoresponseDto = _mapper.Map<Producto, ProductoResponseDto>(producto);
            var response = new ApiResponse<ProductoResponseDto>(productoresponseDto);

            return Ok(response);

        }
    }
}
