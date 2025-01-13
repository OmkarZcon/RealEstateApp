using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Models
{
    public class Brand
    {
        public Guid BrandId { get; set; } 
        public required string   BrandName { get; set; }

    }
}
