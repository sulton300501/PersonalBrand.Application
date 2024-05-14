using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalBrand.Application.Abstraction;
using PersonalBrand.Infrastructure.Persistanse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Infrastructure
{
    public static class AddInfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services ,IConfiguration configuration)
        {
            services.AddDbContext<IPersonalBrandDbContext, PersonalDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("FutureProjectsConnectionString"));
            });
            return services;
        }
    }
}
