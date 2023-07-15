namespace DecoratorPattern.CondimentDecorators.Concrete
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .10d;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Steamed Milk";
        }
    }
}
