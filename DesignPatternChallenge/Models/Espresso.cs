using System;

namespace DesignPatternChallenge.Models;

public class Espresso : ICoffee
{
    public decimal GetCost() => 3.50m;

    public string GetDescription() => "Espresso";
}
