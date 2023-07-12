using AutoMapper;
using MediatR;
using OnionAPI.Application.DTOs;
using OnionAPI.Application.DTOs.Products;
using OnionAPI.Application.UnitOfWork;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        readonly IMapper _mapper;
        readonly IUnitOfWork _unitOfWork;
        public CreateProductCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _unitOfWork.ProductWriteRepository.AddAsync(product);
            _unitOfWork.Save();
            return new();
        }
    }
}
