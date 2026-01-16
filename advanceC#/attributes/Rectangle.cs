[DeBugInfo(45, "zara ali", "12-05-2004", Message = "Initial implimentation")]
[DeBugInfo(459, "ob ali", "13-05-2004", Message = "Finl implimentation")]
class Rectangle
{
    protected double length;
    protected double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    [DeBugInfo(45, "Johny", "45-05-2003", Message = "Final ka final implimentation")]
    public double GetArea()
    {
        return length * width;
    }

    [DeBugInfo(46, "Danny Di", "2024-02-20")]
    public void Display()
    {
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Width: {0}", width);
        Console.WriteLine("Area: {0}", GetArea());
    }

}