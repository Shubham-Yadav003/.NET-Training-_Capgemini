using System;

public abstract class Furniture
{
    protected string color { get; set; }
    public int num { get; set; }
    public int width { get; set; }
    public int height { get; set; }

    public virtual void Accept(){}
    public virtual void Display(){}
    public void MyMethod()
    {
        Console.WriteLine("My Method");
    }
}