using OnionAPI.Application.Repositories;
using OnionAPI.Application.UnitOfWork;
using OnionAPI.Domain.Entities;
using OnionAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork


    {
        private readonly OnionAPIDbContext _context;

        public IProductReadRepository ProductReadRepository { get; }
        public IProductWriteRepository ProductWriteRepository { get; }

        public UnitOfWork(OnionAPIDbContext context, IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _context = context;
            ProductReadRepository = productReadRepository;
            ProductWriteRepository = productWriteRepository;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
