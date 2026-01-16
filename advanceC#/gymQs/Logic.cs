class Logic
{
    public string Tier { get; set; }
    public int MonthPrice { get; set; }
    public int NumberOfMonth { get; set; }

    public bool ValidateEnrollment()
    {
        try
        {
            if (Tier != "basic" && Tier != "premium" && Tier != "elite")
            {
                throw new InvalidTierException("Invalid Tier Exception");
            }

            if (NumberOfMonth <= 0)
            {
                throw new Exception("Number of months must be greater than 0");
            }

            return true; // Validation successful
        }
        catch (InvalidTierException ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public double CalculateTotalBill()
    {
        double totalPrice = MonthPrice * NumberOfMonth;
        double discountPercentage = 0;

        switch (Tier)
        {

            case "Basic":
                discountPercentage = 2;
                break;
            case "Premium":
                discountPercentage = 7;
                break;
            case "Elite":
                discountPercentage = 12;
                break;
        }

        double discountAmount = totalPrice * (discountPercentage / 100);
        return totalPrice - discountAmount;
    }
}


