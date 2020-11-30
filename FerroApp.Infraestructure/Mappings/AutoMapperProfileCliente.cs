using AutoMapper;
using FerroApp.Domain.DTOs;
using FerroApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Mappings
{
  public  class AutoMapperProfileCliente: Profile
    {
        public AutoMapperProfileCliente()
        {
            CreateMap<Cliente, ClienteRequestDto>();
            CreateMap<Cliente, ClienteResponseDto>();
            CreateMap<ClienteRequestDto, Cliente>();
            CreateMap<ClienteResponseDto, Cliente>();
        }
    }
}
