// See https://aka.ms/new-console-template for more information

public abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;

    public override double Cost()
    {
        return this.beverage.Cost() + this.Cost();
    }

    public override string GetDescription()
    {
        return this.description + ", " + this.beverage.GetDescription();
    }
}