using RealEstateApp.Models; // Import the namespace where Brand and Agency are defined

class Program
{
    static void Main(string[] args)
    {
        var brand1 = new Brand { BrandId = Guid.NewGuid(), BrandName = "Ruturaj construction" };
        var brand2 = new Brand { BrandId = Guid.NewGuid(), BrandName = "Ashiyana village" };

        // Create Agency objects
        var agency1 = new Agency { AgencyId = Guid.NewGuid(), AgencyName = " Eon IT-Pune ", AgencyPincode = "410203", BrandId = brand1.BrandId };
        var agency2 = new Agency { AgencyId = Guid.NewGuid(), AgencyName = "Bandra Mumbai", AgencyPincode = "410222", BrandId = brand2.BrandId };

        // Print deatails using loops

        var brands = new List<Brand> { brand1, brand2 };

        var agencies = new List<Agency> { agency1, agency2 };

        Console.WriteLine("Brands:");   
        foreach (var brand in brands)
        {
            Console.WriteLine($"ID: {brand.BrandId}, Name: {brand.BrandName}");
        }

        Console.WriteLine("Agencies:");
        foreach (var agency in agencies)
        {

            var brand = brands.Find(b => b.BrandId == agency.BrandId);
            Console.WriteLine($"ID: {agency.AgencyId}, Name: {agency.AgencyName}, PinCode: {agency.AgencyPincode},BrandID: {brand?.BrandId} ");
        }











        // Print details
        //Console.WriteLine("Brands:");
        //Console.WriteLine($"ID: {brand1.BrandId}, Name: {brand1.BrandName}");
        //Console.WriteLine($"ID: {brand2.BrandId}, Name: {brand2.BrandName}");

        //Console.WriteLine("\nAgencies:");
        //Console.WriteLine($"ID: {agency1.AgencyId}, Name: {agency1.AgencyName}, Brand ID: {agency1.BrandId}, PinCode: {agency1.AgencyPincode}");

        //Console.WriteLine($"ID: {agency2.AgencyId}, Name: {agency2.AgencyName}, Brand ID: {agency2.BrandId}, PinCode: {agency2.AgencyPincode}");
    }
}
