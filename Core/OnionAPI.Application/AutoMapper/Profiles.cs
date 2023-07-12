using AutoMapper;
using OnionAPI.Application.DTOs.Mudurluks;
using OnionAPI.Application.DTOs.Products;
using OnionAPI.Application.Features.Commands.CreateProduct;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.AutoMapper
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<CreateProductCommandRequest, Product>().ReverseMap();
            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<MudurlukDTO, Mudurluk>().ReverseMap();
        }
    }
}
