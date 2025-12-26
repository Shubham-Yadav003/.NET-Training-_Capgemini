using System;

class Car : Vehicle // child class from nbase class
{   // 
    public Car(double distance, double hour, double fuel) : base(distance, hour, fuel)
    {

    }

    public new void Average() // hides bas class method avg
    {
        double avg = 0.0;
        avg = distance / fuel;
        Console.WriteLine($"average milege: {avg}");
    }

    public override void Speed()
    {
        double speed = 0.0;
        speed = distance / hour;
        Console.WriteLine($"Speed: {speed}");
    }
}