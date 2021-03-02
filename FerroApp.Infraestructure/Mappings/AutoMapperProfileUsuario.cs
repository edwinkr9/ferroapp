using AutoMapper;
using FerroApp.Domain.DTOs;
using FerroApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Mappings
{
   public class AutoMapperProfileUsuario: Profile
    {
        public AutoMapperProfileUsuario()
        {
            CreateMap<Usuario, UsuarioRequestDto>();
            CreateMap < Usuario, UsuarioResponseDto>();
            CreateMap<UsuarioRequestDto, Usuario>();
            CreateMap<UsuarioResponseDto, Usuario>();
        }
    }
}
