using OnionAPI.Application.Abstraction;
using OnionAPI.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnionAPI.Persistence.Concretes
{
    internal class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
             new Product { Price = 1, Stock = 1, Name = "bir", CreateDate = DateTime.Now, Id = new Guid()},
             new Product { Price = 1, Stock = 1, Name = "iki", CreateDate = DateTime.Now, Id = new Guid()}
            };

        
            return products;
        }
    }
}
