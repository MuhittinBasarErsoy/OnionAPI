using OnionAPI.Application.DTOs.Products;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Queries.GetAllProduct
{
    public class GetAllProductQueryResponse
    {
        public List<ProductDTO> Products { get; set; }
    }
}
