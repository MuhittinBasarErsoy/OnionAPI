using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OnionAPI.Application.DTOs;
using OnionAPI.Application.Features.Commands.Product.CreateProduct;
using OnionAPI.Application.Features.Queries.Product.GetAllProduct;
using OnionAPI.Application.Repositories;
using OnionAPI.Application.UnitOfWork;
using OnionAPI.Domain.Entities;
using System.Net;

namespace OnionAPI.API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        IUnitOfWork _unitOfWork;
        Serilog.ILogger _logger;
        IMediator _mediator;

        public ProductController(IUnitOfWork unitOfWork, Serilog.ILogger logger, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost(Name = "Save")]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpGet("Get")]
        [Authorize(AuthenticationSchemes = "GenelMudur")]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }

    }
}
