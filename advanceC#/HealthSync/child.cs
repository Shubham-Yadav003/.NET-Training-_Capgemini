using System.Text.RegularExpressions;

class Child : Parent
{


    public override bool Validate()
    {
        string ConsultantId = Id;
        string pattern = @"^DR\d{4}$";
        return Regex.IsMatch(ConsultantId, pattern);
    }

    public override void CalculateAmount()
    {
        double gross = 0;
        double tax = 0;
        double totalAmount = 0;
        if (Type == "In-House" && Stipend > 5000)
        {
            gross = (Stipend + 3000);
            tax = 15 / 100;
            totalAmount = gross - tax;
            Console.WriteLine($"Gross: {gross} | TDS Applied: 15% | Net Payable: {totalAmount}");
        }
        else if (Type == "In-House" && Stipend < 5000)
        {
            gross = Stipend;
            tax = 5 / 100;
            totalAmount = gross - tax;
            Console.WriteLine($"Gross: {gross} | TDS Applied: 15% | Net Payable: {totalAmount}");
        }
        else if (Type == "Visiting")
        {
            gross = Stipend;
            tax = 10 / 100;
            totalAmount = gross - tax;
            Console.WriteLine($"Gross: {gross} | TDS Applied: 15% | Net Payable: {totalAmount}");
        }

    }


}