using FluentValidation;
using OnionAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Validators.Products
{
    public class CreateProductValidator: AbstractValidator<CreateProductDTO>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Products null veya empty olmamalı").MaximumLength(5).WithMessage("max length hatası");

        }
    }
}
