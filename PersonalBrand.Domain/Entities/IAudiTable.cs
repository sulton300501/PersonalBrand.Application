using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Domain.Entities
{
    public interface IAudiTable
    {
        public DateTimeOffset CreateDate { get; set; } 
        public DateTimeOffset ModifiedDate { get; set;}
         public DateTimeOffset DeletedDate { get; set; }
        public bool isDeleted { get; set; } 
    }
}
