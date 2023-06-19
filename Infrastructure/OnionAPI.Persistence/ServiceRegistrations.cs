using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionAPI.Persistence.Contexts;

namespace OnionAPI.Persistence
{
    public static class ServiceRegistrations
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<OnionAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
