using AutoMapper;
using FerroApp.Domain.DTOs;
using FerroApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Mappings
{
   public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Producto, ProductoRequestDto>();
            CreateMap<Producto, ProductoResponseDto>();
            CreateMap<ProductoRequestDto, Producto>();
            CreateMap<ProductoResponseDto, Producto>();
        } 

    }
}
