﻿namespace DecoratorPattern.Beverages.Concrete
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override double Cost()
        {
            return 0.99d;
        }
    }
}
