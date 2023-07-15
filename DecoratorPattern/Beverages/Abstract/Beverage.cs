// See https://aka.ms/new-console-template for more information
public abstract class Beverage
{
    public string description = "Unknown Beverage";

    public virtual string GetDescription()
    {
        return description;
    }

    public abstract double Cost();
}
