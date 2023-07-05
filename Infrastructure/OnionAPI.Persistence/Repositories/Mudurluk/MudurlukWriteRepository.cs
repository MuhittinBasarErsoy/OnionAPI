using OnionAPI.Application.Repositories;
using OnionAPI.Domain.Entities;
using OnionAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Persistence.Repositories
{
    public class MudurlukWriteRepository : WriteRepository<Mudurluk>, IMudurlukWriteRepository
    {
        public MudurlukWriteRepository(OnionAPIDbContext context) : base(context)
        {
        }
    }
}
