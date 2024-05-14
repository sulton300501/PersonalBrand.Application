using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PersonalBrand.Domain.Entities;
using PersonalBrand.Infrastructure.Persistanse;

namespace PersonalBrand.API.PersonalIdentity
{
    public static class IdentityExtension
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<UserModel, IdentityRole>()
                .AddEntityFrameworkStores<PersonalDbContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
