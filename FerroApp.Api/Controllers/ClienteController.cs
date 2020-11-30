using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FerroApp.Domain.DTOs;
using FerroApp.Domain.Entities;
using FerroApp.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FerroApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;


        //public ProductoController(IProductoRepository repository)
        //{
        //    this._repository = repository;
        //}
        public ClienteController(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            this._mapper = mapper;
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _repository.DeleteCliente(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, ClienteRequestDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            var result = await _repository.UpdateCliente(cliente);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientes = await _repository.GetCliente();
            var clienteDto = _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteResponseDto>>(clientes);
            return Ok(clienteDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var cliente = await _repository.GetCliente(id);
            //var config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoResponseDto>());
            //var _mapper = new Mapper(config);
            var clienteDto = _mapper.Map<Cliente, ClienteResponseDto>(cliente);
            return Ok(clienteDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ClienteRequestDto clienteDto)
        {
            //var config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoRequestDto>());
            //var _mapper = new Mapper(config);
            var cliente = _mapper.Map<ClienteRequestDto, Cliente>(clienteDto);
            await _repository.AddCliente(cliente);

            //config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoResponseDto>());
            //_mapper = new Mapper(config);
            var clienteresponseDto = _mapper.Map<Cliente, ClienteResponseDto>(cliente);
            return Ok(clienteresponseDto);
        }
    }
}
