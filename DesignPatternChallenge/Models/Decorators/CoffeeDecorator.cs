using System;

namespace DesignPatternChallenge.Models.Decorators;

public class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual decimal GetCost() => _coffee.GetCost();

    public virtual string GetDescription() => _coffee.GetDescription();
}
