using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OnionAPI.Application.DTOs;
using OnionAPI.Application.Features.Queries.Mudurluk.GetAllMudurluk;
using OnionAPI.Application.Repositories;
using OnionAPI.Application.UnitOfWork;
using OnionAPI.Domain.Entities;
using StackExchange.Redis;

namespace OnionAPI.API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MudurlukController : ControllerBase
    {
        IUnitOfWork _unitOfWork;
        Serilog.ILogger _logger;
        private readonly IMapper _mapper;
        private IDatabase _database;
        IMediator _mediator;

        public MudurlukController(IUnitOfWork unitOfWork, Serilog.ILogger logger, IMapper mapper, IDatabase database, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _database = database;
            _mediator = mediator;
        }


        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetAllMudurlukQueryRequest getAllMudurlukQueryRequest)
        {
            GetAllMudurlukQueryResponse response = await _mediator.Send(getAllMudurlukQueryRequest);
            return Ok(response);
        }


    }
}
