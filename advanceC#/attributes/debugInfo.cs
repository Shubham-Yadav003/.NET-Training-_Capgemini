[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true
)]
public class DeBugInfo : System.Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    public string message;

    public DeBugInfo(int bg, string dev, string d)
    {
        bugNo = bg;
        developer = dev;
        lastReview = d;
    }

    public int BugNo
    {
        get { return bugNo; }
    }

    public string Developer
    {
        get { return developer; }
    }

    public string LastReview
    {
        get { return lastReview; }
    }

    public string Message
    {
        get { return message; }
        set { message = value; }
    }

}