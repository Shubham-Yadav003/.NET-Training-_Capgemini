using System;

class Vehicle
{
    protected double distance = 0.0;
    protected double hour = 0.0;
    protected double fuel = 0.0;

    public Vehicle(double distance, double hour, double fuel)
    {
        this.distance = distance;
        this.hour = hour;
        this.fuel = fuel;
    
    }

    public  void Average() // new to hide base class implementation
    {
        double avg = 0.0;
        avg = distance/fuel;
        Console.WriteLine($"average milege: {avg}");
    }

    public  virtual void Speed()
    {
        double speed = 0.0;
        speed = distance/hour;
        Console.WriteLine($"Speed: {speed}");
    }
}