using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OnionAPI.Application.DTOs;
using OnionAPI.Application.Repositories;
using OnionAPI.Application.UnitOfWork;
using OnionAPI.Domain.Entities;

namespace OnionAPI.API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IUnitOfWork _unitOfWork;
        Serilog.ILogger _logger;

        public ProductController(IUnitOfWork unitOfWork, Serilog.ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpPost(Name = "Save")]
        public async void Save(CreateProductDTO createProductDTO)
        {
            if(ModelState.IsValid)
            {

            }

            List<Product> lstProducts = new List<Product>
            {
                new Product{ Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, Name="bir", Price=1, Stock=1},
                new Product{ Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, Name="iki", Price=1, Stock=1},
                new Product{ Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, Name="üç", Price=1, Stock=1},
                new Product{ Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, Name="dört", Price=1, Stock=1}
            };

            _unitOfWork.ProductWriteRepository.AddRangeAsync(lstProducts);

            _unitOfWork.Save();
        }

        [HttpGet(Name = "Get")]
        public IActionResult Get()
        {
            var products = _unitOfWork.ProductReadRepository.GetAll();
            return Ok(products);
        }

    }
}
