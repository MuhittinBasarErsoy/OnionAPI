using AutoMapper;
using OnionAPI.Application.DTOs;
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
            CreateMap<CreateProductDTO,Product>().ReverseMap();
            CreateMap<MudurlukDTO, Mudurluk>().ReverseMap();
        }
    }
}
