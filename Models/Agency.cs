using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Models
{
    public class Agency
    {
        public Guid AgencyId { get; set; } 
        public required string AgencyName { get; set; } 
        
        public Guid BrandId { get; set; }

        public required string AgencyPincode { get; set; }
    }
}
