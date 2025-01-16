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
