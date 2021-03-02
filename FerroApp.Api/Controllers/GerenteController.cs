using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FerroApp.Domain.DTOs;
using FerroApp.Domain.Entities;
using FerroApp.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using FerroApp.Api.Responses;
using Microsoft.AspNetCore.Mvc;

namespace FerroApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenteController : ControllerBase
    {
        private readonly IGerenteRepository _repository;
        private readonly IMapper _mapper;

        public GerenteController(IGerenteRepository repository, IMapper mapper)
        {
            _repository = repository;
            this._mapper = mapper;
        }


        //Metodo de borrar gerente

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _repository.DeleteGerente(id);
            var response = new ApiResponse<bool>(result);

            return Ok(response);


        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de modificar gerente

        [HttpPut]
        public async Task<IActionResult> Put(int id, GerenteRequestDto gerenteDto)
        {
            var gerente = _mapper.Map<Gerente>(gerenteDto);
            var result = await _repository.UpdateGerente(gerente);
            var response = new ApiResponse<bool>(result);

            return Ok(response);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de obtener lista completa de gerentes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var gerentes = await _repository.GetGerente();
            var gerenteDto = _mapper.Map<IEnumerable<Gerente>, IEnumerable<GerenteResponseDto>>(gerentes);
            var response = new ApiResponse<IEnumerable<GerenteResponseDto>>(gerenteDto);

            return Ok(response);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de obtener por id a los gerentes
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var gerente = await _repository.GetGerente(id);
            //var config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoResponseDto>());
            //var _mapper = new Mapper(config);
            var gerenteDto = _mapper.Map<Gerente, GerenteResponseDto>(gerente);
            var response = new ApiResponse<GerenteResponseDto>(gerenteDto);

            return Ok(response);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo de crear a los gerentes
        [HttpPost]
        public async Task<IActionResult> Post(GerenteRequestDto gerenteDto)
        {

            var gerente = _mapper.Map<GerenteRequestDto, Gerente>(gerenteDto);
            await _repository.AddGerente(gerente);

            var gerenteresponseDto = _mapper.Map<Gerente, GerenteResponseDto>(gerente);
            var response = new ApiResponse<GerenteResponseDto>(gerenteresponseDto);

            return Ok(response);
        }
    }
}
