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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FerroApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            this._mapper = mapper;
        }

        //Metodo de borrar usuario
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _repository.DeleteUsuario(id);
            var response = new ApiResponse<bool>(result);

            return Ok(response);

            // var result = await _repository.DeleteCliente(id);
            // return Ok(result);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de modificar usuarios
        [HttpPut]
        public async Task<IActionResult> Put(int id, UsuarioRequestDto usuarioDto)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDto);
            var result = await _repository.UpdateUsuario(usuario);
            var response = new ApiResponse<bool>(result);

            return Ok(response);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///        //Metodo de obtener lista de usuarios
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _repository.GetUsuario();
            var usuarioDto = _mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioResponseDto>>(usuarios);
            var response = new ApiResponse<IEnumerable<UsuarioResponseDto>>(usuarioDto);

            return Ok(usuarioDto);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de obtener por id a los usuarios
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var usuario = await _repository.GetUsuario(id);
            var usuarioDto = _mapper.Map<Usuario, UsuarioResponseDto>(usuario);
            var response = new ApiResponse<UsuarioResponseDto>(usuarioDto);

            return Ok(usuarioDto);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de crear a los usuarios
        [HttpPost]
        public async Task<IActionResult> Post(UsuarioRequestDto usuarioDto)
        {
            var usuario = _mapper.Map<UsuarioRequestDto, Usuario>(usuarioDto);
            await _repository.AddUsuario(usuario);
            var usuarioresponseDto = _mapper.Map<Usuario,UsuarioResponseDto>(usuario);
            var response = new ApiResponse<UsuarioResponseDto>(usuarioresponseDto);

            return Ok(response);

        }
    }

}
