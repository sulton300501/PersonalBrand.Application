using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Domain.Entities
{
    public class UserModel :IdentityUser , IAudiTable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset ModifiedDate { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
