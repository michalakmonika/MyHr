using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyHr.Domain.Interfaces;
using MyHr.Infrastructure.Persistence;
using MyHr.Infrastructure.Repositories;
using MyHr.Infrastructure.Seeders;

namespace MyHr.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyHrDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyHr")));

            services.AddScoped<EmployeeSeeder>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
