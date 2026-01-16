using System;

class Program
{
    public static void Main()
    {
        // Input Phase
        Console.WriteLine("Enter Shipment Code:");
        string shipmentCode = Console.ReadLine();

        // Create ShipmentDetails object
        ShipmentDetails shipment = new ShipmentDetails();
        shipment.ShipmentCode = shipmentCode;

        // Validation Phase
        if (!shipment.ValidateShipmentCode())
        {
            Console.WriteLine("Invalid shipment code");
            return;
        }

        // Collect additional details
        Console.WriteLine("Enter Transport Mode (Sea/Air/Land):");
        shipment.TransportMode = Console.ReadLine();

        Console.WriteLine("Enter Weight (in Kg):");
        shipment.Weight = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Enter Storage Days:");
        shipment.StorageDays = int.Parse(Console.ReadLine() ?? "0");

        // Calculation Phase
        double totalCost = shipment.CalculateTotalCost();
        Console.WriteLine($"The total shipping cost is {totalCost:F2}");
    }
}
