using OnionAPI.Application.Repositories;
using OnionAPI.Domain.Entities;
using OnionAPI.Persistence.Contexts;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Persistence.Repositories
{
    public class MudurlukReadRepository : ReadRepository<Mudurluk>, IMudurlukReadRepository
    {
        public MudurlukReadRepository(OnionAPIDbContext context, IDatabase cacheRepository) : base(context, cacheRepository)
        {
        }
    }
}
