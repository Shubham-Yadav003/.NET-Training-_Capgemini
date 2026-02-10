public class Bike
{
    public string? Model { get; set; }
    public int PricePerDay { get; set; }
    public string? Brand { get; set; }

    public static SortedDictionary<int, Bike> dict = new SortedDictionary<int, Bike>();

}

public class Program
{
    public static void Main(string[] args)
    {
        BikeUtility bikeUtility = new BikeUtility();

        bikeUtility.AddBike("Model1", "BrandA", 100);
        bikeUtility.AddBike("Model2", "BrandB", 150);
        bikeUtility.AddBike("Model3", "BrandA", 120);
        bikeUtility.AddBike("Model5", "BrandA", 150);

        SortedDictionary<string, List<Bike>> groupedBikes = bikeUtility.GroupBike();

        foreach (var brand in groupedBikes)
        {
            Console.WriteLine($"Brand: {brand.Key}");
            foreach (var bike in brand.Value)
            {
                Console.WriteLine($"  Model: {bike.Model}, Price Per Day: {bike.PricePerDay}");
            }
        }
    }
}