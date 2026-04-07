using System;

namespace DesignPatternChallenge.Models.Decorators;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override decimal GetCost() => base.GetCost() + 0.50m;

    public override string GetDescription() => base.GetDescription() + " Milk";
}
