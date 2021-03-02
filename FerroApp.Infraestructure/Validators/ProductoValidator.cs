using FerroApp.Domain.DTOs;
using FerroApp.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Validators
{
    public class ProductoValidator: AbstractValidator<ProductoRequestDto>
    {
        public ProductoValidator()
        {
            
        }
    }
}
