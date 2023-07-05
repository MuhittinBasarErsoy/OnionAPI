using OnionAPI.Application.Repositories;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductReadRepository ProductReadRepository { get; }
        IProductWriteRepository ProductWriteRepository { get; }
        IMudurlukReadRepository MudurlukReadRepository { get; }
        IMudurlukWriteRepository MudurlukWriteRepository { get; }
        int Save();
    }
}
