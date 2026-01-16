using System;

class ShipmentDetails : Shipment
{
    public bool ValidateShipmentCode()
    {
        // Check length is exactly 7 characters
        if (ShipmentCode.Length != 7)
            return false;

        // Check prefix is "GC#"
        if (!ShipmentCode.StartsWith("GC#"))
            return false;

        // Check characters after prefix are digits
        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(ShipmentCode[i]))
                return false;
        }

        return true;
    }

    public double CalculateTotalCost()
    {
        double ratePerKg = 0;

        // Determine rate based on transport mode
        switch (TransportMode)
        {
            case "Sea":
                ratePerKg = 15.00;
                break;
            case "Air":
                ratePerKg = 50.00;
                break;
            case "Land":
                ratePerKg = 25.00;
                break;
            default:
                ratePerKg = 0; // Invalid mode
                break;
        }

        // Formula: (Weight × RatePerKg) + √StorageDays
        double totalCost = (Weight * ratePerKg) + Math.Sqrt(StorageDays);

        // Round to 2 decimal places
        return Math.Round(totalCost, 2);
    }
}
