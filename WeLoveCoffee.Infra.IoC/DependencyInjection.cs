using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeLoveCoffee.Application.Interfaces;
using WeLoveCoffee.Application.Mappings;
using WeLoveCoffee.Application.Services;
using WeLoveCoffee.Domain.Interfaces;
using WeLoveCoffee.Infra.Data.Context;
using WeLoveCoffee.Infra.Data.Repositories;

namespace WeLoveCoffee.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(configuration.GetConnectionString("Connection"),
                a => a.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICompanyServices, CompanyService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}