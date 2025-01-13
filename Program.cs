using RealEstateApp.Models; // Import the namespace where Brand and Agency are defined

class Program
{
    static void Main(string[] args)
    {
        // Create Brand objects
        var brand1 = new Brand { BrandId = Guid.NewGuid(), BrandName = "Ruturaj construction" };
        var brand2 = new Brand { BrandId = Guid.NewGuid(), BrandName = "Ashiyana village" };

        // Create Agency objects
        var agency1 = new Agency { AgencyId = Guid.NewGuid(), AgencyName = " Eon IT-Pune ", AgencyPincode = "410203", BrandId = brand1.BrandId };
        var agency2 = new Agency { AgencyId = Guid.NewGuid(), AgencyName = "Bandra Mumbai", AgencyPincode = "410222", BrandId = brand2.BrandId };

        // Print details
        Console.WriteLine("Brands:");
        Console.WriteLine($"ID: {brand1.BrandId}, Name: {brand1.BrandName}");
        Console.WriteLine($"ID: {brand2.BrandId}, Name: {brand2.BrandName}");

        Console.WriteLine("\nAgencies:");
        Console.WriteLine($"ID: {agency1.AgencyId}, Name: {agency1.AgencyName}, Brand ID: {agency1.BrandId}, PinCode: {agency1.AgencyPincode}");

        Console.WriteLine($"ID: {agency2.AgencyId}, Name: {agency2.AgencyName}, Brand ID: {agency2.BrandId}, PinCode: {agency2.AgencyPincode}");
    }
}
