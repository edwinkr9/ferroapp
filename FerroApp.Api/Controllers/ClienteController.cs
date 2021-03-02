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
using FerroApp.Api.Responses;

namespace FerroApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;


        public ClienteController(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            this._mapper = mapper;
        }
        //Metodo de borrar clientes
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _repository.DeleteCliente(id);
            var response = new ApiResponse<bool>(result);

            return Ok(response);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de modificar cientes
        [HttpPut]
        public async Task<IActionResult> Put(int id, ClienteRequestDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            var result = await _repository.UpdateCliente(cliente);
            var response = new ApiResponse<bool>(result);

            return Ok(response);




          /*  var cliente = _mapper.Map<Cliente>(clienteDto);
            var result = await _repository.UpdateCliente(cliente);
            return Ok(result);*/
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de obtener lista de clientes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientes = await _repository.GetCliente();
            var clienteDto = _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteResponseDto>>(clientes);
            var response = new ApiResponse<IEnumerable<ClienteResponseDto>>(clienteDto);

            return Ok(response);




           /* var clientes = await _repository.GetCliente();
            var clienteDto = _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteResponseDto>>(clientes);
            return Ok(clienteDto);*/
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de obtener por id a los clientes
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var cliente = await _repository.GetCliente(id);
            var clienteDto = _mapper.Map<Cliente, ClienteResponseDto>(cliente);
            var response = new ApiResponse<ClienteResponseDto>(clienteDto);

            return Ok(response);


            /*var cliente = await _repository.GetCliente(id);
 
            var clienteDto = _mapper.Map<Cliente, ClienteResponseDto>(cliente);
            return Ok(clienteDto);*/
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de crear a los clientes
        [HttpPost]
        public async Task<IActionResult> Post(ClienteRequestDto clienteDto)
        {
            var cliente = _mapper.Map<ClienteRequestDto, Cliente>(clienteDto);
            await _repository.AddCliente(cliente);
            var clienteresponseDto = _mapper.Map<Cliente, ClienteResponseDto>(cliente);
            var response = new ApiResponse<ClienteResponseDto>(clienteresponseDto);

            return Ok(response);

            /*
            var cliente = _mapper.Map<ClienteRequestDto, Cliente>(clienteDto);
            await _repository.AddCliente(cliente);

        
            var clienteresponseDto = _mapper.Map<Cliente, ClienteResponseDto>(cliente);
            return Ok(clienteresponseDto);*/
        }
    }
}
