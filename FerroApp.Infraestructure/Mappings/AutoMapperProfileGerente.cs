using AutoMapper;
using FerroApp.Domain.DTOs;
using FerroApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Mappings
{
    public class AutoMapperProfileGerente : Profile
    {
        public AutoMapperProfileGerente()
        {
            CreateMap<Gerente, GerenteRequestDto>();
            CreateMap<Gerente, GerenteResponseDto>();
            CreateMap<GerenteRequestDto, Gerente>();
            CreateMap<GerenteResponseDto, Gerente>();
        }
    }
}
