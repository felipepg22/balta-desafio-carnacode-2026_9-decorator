using System;

namespace DesignPatternChallenge.Models.Decorators;

public class ChantillyDecorator : CoffeeDecorator
{
    public ChantillyDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override decimal GetCost() => base.GetCost() + 1.00m;

    public override string GetDescription() => base.GetDescription() + " Chantilly";
}
