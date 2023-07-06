using Microsoft.EntityFrameworkCore;
using OnionAPI.Application.Repositories;
using OnionAPI.Domain.Entities;
using OnionAPI.Domain.Entities.Common;
using OnionAPI.Persistence.Contexts;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OnionAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly IDatabase _cacheRepository;
        private readonly OnionAPIDbContext _context;
        public ReadRepository(OnionAPIDbContext context, IDatabase cacheRepository)
        {
            _context = context;
            _cacheRepository = cacheRepository;
        }

        public DbSet<T> Table => _context.Set<T>();

        public List<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query.ToList();
        }

        public List<T> GetAllFromCache(bool tracking = true)
        {
            if (!_cacheRepository.KeyExists(typeof(T).FullName))
                return LoadToCacheFromDb();

            var items = new List<T>();

            var cacheItems = _cacheRepository.HashGetAll(typeof(T).FullName);
            foreach (var item in cacheItems.ToList())
            {
                var it = JsonSerializer.Deserialize<T>(item.Value);

                items.Add(it);

            }

            return items;
        }

        public List<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query.ToList();
        }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }
        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        //=> await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        //=> await Table.FindAsync(Guid.Parse(id));
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        }
        private List<T> LoadToCacheFromDb()
        {
            string itemKey = typeof(T).FullName;
            var items = GetAll();


            items.ForEach(p =>
            {
                _cacheRepository.HashSet(itemKey, p.Id.ToString(), JsonSerializer.Serialize(p));
                _cacheRepository.KeyExpire(itemKey, new TimeSpan(0, 0, 180));

            });

            return items;


        }
    }
}
