using System;

namespace DesignPatternChallenge.Models.Decorators;

public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override decimal GetCost() => base.GetCost() + 0.70m;

    public override string GetDescription() => base.GetDescription() + " Chocolate";
}
