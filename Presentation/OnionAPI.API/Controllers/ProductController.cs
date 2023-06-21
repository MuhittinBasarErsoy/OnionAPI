using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OnionAPI.Application.Repositories;
using OnionAPI.Domain.Entities;

namespace OnionAPI.API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet(Name = "Save")]
        public async void Save()
        {
            List<Product> lstProducts = new List<Product>
            {
                new Product{ Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, Name="bir", Price=1, Stock=1},
                new Product{ Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, Name="iki", Price=1, Stock=1},
                new Product{ Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, Name="üç", Price=1, Stock=1},
                new Product{ Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow, Name="dört", Price=1, Stock=1}
            };
            _productWriteRepository.AddRangeAsync(lstProducts);
            _productWriteRepository.SaveAsync();
        }

        [HttpGet(Name = "Get")]
        public IActionResult Get()
        {
            var products = _productReadRepository.GetAll();
            return Ok(products);
        }

    }
}
