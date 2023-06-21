using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionAPI.Application.Repositories;
using OnionAPI.Persistence.Contexts;
using OnionAPI.Persistence.Repositories;

namespace OnionAPI.Persistence
{
    public static class ServiceRegistrations
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<OnionAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
