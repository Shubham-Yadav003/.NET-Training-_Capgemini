using System;

class CaseStudy
{
    public void CalculateLength(double value, string fromUnit, string toUnit)
    {
        double val = 0;

        // Convert fromUnit to Meter (standard unit)
        double inMeters = 0;
        if (fromUnit == "Kilometer" && toUnit == "Meter")
        {
            inMeters = value * 1000;
        }
        else if (fromUnit == "Meter" && toUnit == "Kilometer")
        {
            inMeters = value / 1000;
        }
        else if (fromUnit == "Feet" && toUnit == "Miles")
        {
            inMeters = value / 3.28084;
        }
        else if (fromUnit == "Miles" && toUnit == "Feet")
        {
            inMeters = value * 3280.84;
        }
        else
        {
            Console.WriteLine($"Invalid fromUnit: {fromUnit}");
            return;
        }

        val = inMeters;
        Console.WriteLine($"fromUnit: {fromUnit} toUnit: {toUnit} finalValue: {val}");
    }

    public void CalculateWeight(double value, string fromUnit, string toUnit)
    {
        double val = 0;

        // Convert fromUnit to Kilogram (standard unit)
        double inKilogram = 0;

        if (fromUnit == "Gram" && toUnit == "Kilogram")
        {
            inKilogram = value * 0.001;
        }
        else if (fromUnit == "Kilogram" && toUnit == "Gram")
        {
            inKilogram = value * 1000;
        }
        else if (fromUnit == "Ounce" && toUnit == "pounds")
        {
            inKilogram = value * 0.0283495;
        }
        else if (fromUnit == "pounds" && toUnit == "Ounce")
        {
            inKilogram = value * 0.453592;
        }
        else
        {
            Console.WriteLine($"Invalid fromUnit: {fromUnit}");
            return;
        }

        val = inKilogram;
        Console.WriteLine($"fromUnit: {fromUnit} toUnit: {toUnit} finalValue: {val}");
    }

    public void CalculateTemperature(double value, string fromUnit, string toUnit)
    {
        double val = 0;

        // Convert fromUnit to Celsius (standard unit)
        double inCelsius = 0;

        if (fromUnit == "Kelvin" && toUnit == "Celsius")
        {
            inCelsius = value - 273.15;
        }
        else if (fromUnit == "Celcius" && toUnit == "Kelvin")
        {
            inCelsius = value + 273.15;
        }
        else if (fromUnit == "Fahrenheit" && toUnit == "Celsius")
        {
            inCelsius = (value - 32) * (5.0 / 9);
        }
        else if (fromUnit == "Celcius" && toUnit == "Fahrenheit")
        {
            inCelsius = (value * 9 / 5) + 32;
        }
        else
        {
            Console.WriteLine($"Invalid fromUnit: {fromUnit}");
            return;
        }

        val = inCelsius;
        Console.WriteLine($"fromUnit: {fromUnit} toUnit: {toUnit} finalValue: {val}");
    }



    public void Default(double value, string fromUnit)
    {
        double val = 0;

        // Length conversions to Kilometer
        if (fromUnit == "Kilometer")
        {
            val = value;
        }
        else if (fromUnit == "Meter")
        {
            val = value / 1000;
        }
        else if (fromUnit == "Feet")
        {
            val = value / 3280.84;
        }
        else if (fromUnit == "Miles")
        {
            val = value * 1.60934;
        }

        // Weight conversions to Kilogram
        else if (fromUnit == "Kilogram")
        {
            val = value;
        }
        else if (fromUnit == "Gram")
        {
            val = value / 1000;
        }
        else if (fromUnit == "Ounce")
        {
            val = value * 0.0283495;
        }
        else if (fromUnit == "pounds")
        {
            val = value * 0.453592;
        }

        // Temperature conversions to Celsius
        else if (fromUnit == "Celsius")
        {
            val = value;
        }
        else if (fromUnit == "Kelvin")
        {
            val = value - 273.15;
        }
        else if (fromUnit == "Fahrenheit")
        {
            val = (value - 32) * (5.0 / 9);
        }
        else
        {
            Console.WriteLine($"Invalid unit: {fromUnit}");
            return;
        }

        Console.WriteLine($"Value: {value} {fromUnit} converted to default unit: {val}");
    }
}