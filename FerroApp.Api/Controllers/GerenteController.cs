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
    public class GerenteController : ControllerBase
    {
        private readonly IGerenteRepository _repository;
        private readonly IMapper _mapper;


        //public ProductoController(IProductoRepository repository)
        //{
        //    this._repository = repository;
        //}
        public GerenteController(IGerenteRepository repository, IMapper mapper)
        {
            _repository = repository;
            this._mapper = mapper;
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _repository.DeleteGerente(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, GerenteRequestDto gerenteDto)
        {
            var gerente = _mapper.Map<Gerente>(gerenteDto);
            var result = await _repository.UpdateGerente(gerente);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var gerentes = await _repository.GetGerente();
            var gerenteDto = _mapper.Map<IEnumerable<Gerente>, IEnumerable<GerenteResponseDto>>(gerentes);
            return Ok(gerenteDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var gerente = await _repository.GetGerente(id);
            //var config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoResponseDto>());
            //var _mapper = new Mapper(config);
            var gerenteDto = _mapper.Map<Gerente, GerenteResponseDto>(gerente);
            return Ok(gerenteDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(GerenteRequestDto gerenteDto)
        {
            //var config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoRequestDto>());
            //var _mapper = new Mapper(config);
            var gerente = _mapper.Map<GerenteRequestDto, Gerente>(gerenteDto);
            await _repository.AddGerente(gerente);

            //config = new MapperConfiguration(mc => mc.CreateMap<Producto, ProductoResponseDto>());
            //_mapper = new Mapper(config);
            var gerenteresponseDto = _mapper.Map<Gerente, GerenteResponseDto>(gerente);
            return Ok(gerenteresponseDto);
        }
    }
}
