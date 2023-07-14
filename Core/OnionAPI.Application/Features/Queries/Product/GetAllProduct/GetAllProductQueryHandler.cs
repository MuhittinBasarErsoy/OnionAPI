using AutoMapper;
using MediatR;
using OnionAPI.Application.DTOs;
using OnionAPI.Application.DTOs.Products;
using OnionAPI.Application.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Queries.Product.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        readonly IMapper _mapper;
        readonly IUnitOfWork _unitOfWork;
        public GetAllProductQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var productDto = _mapper.Map<List<ProductDTO>>(_unitOfWork.ProductReadRepository.GetAll());
            return new()
            {

                Products = productDto
            };
        }
    }
}
