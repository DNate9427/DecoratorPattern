using DecoratorPattern.Beverages.Concrete;
using DecoratorPattern.CondimentDecorators.Concrete;

Beverage beverage = new Espresso();
Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());
Console.WriteLine();

Beverage beverage2 = new DarkRoast();
beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);
Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());
Console.WriteLine();

Beverage beverage3 = new Decaf();
beverage3 = new Mocha(beverage3);
beverage3 = new Soy(beverage3);
beverage3 = new SteamedMilk(beverage3);
beverage3 = new Whip(beverage3);
Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());