using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalBrand.Application.Abstraction;
using PersonalBrand.Domain.DTOs;
using PersonalBrand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Infrastructure.Persistanse
{
    public class PersonalDbContext : IdentityDbContext<UserModel> , IPersonalBrandDbContext
    {
        public PersonalDbContext(DbContextOptions<PersonalDbContext> options):base(options) { }

        public DbSet<Login> TestLoginTable { get; set; }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
