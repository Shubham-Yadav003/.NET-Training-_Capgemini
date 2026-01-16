abstract class Parent
{
    public string? Type { get; set; }
    public String Id { get; set; }
    public int Stipend { get; set; }

    public abstract void CalculateAmount();


    public abstract bool Validate();


}