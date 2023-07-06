using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OnionAPI.Application.DTOs;
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

        public MudurlukController(IUnitOfWork unitOfWork, Serilog.ILogger logger, IMapper mapper, IDatabase database)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _database = database;
        }


        [HttpGet("Get")]
        public IActionResult Get()
        {
            var mudurlukler = _unitOfWork.MudurlukReadRepository.GetAllFromCache();
            var mapped = _mapper.Map<List<MudurlukDTO>>(mudurlukler);
            return Ok(mapped);
        }

    }
}
