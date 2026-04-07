namespace DesignPatternChallenge.Models;

public class Cappuccino : ICoffee
{
    public decimal GetCost() => 4.50m;

    public string GetDescription() => "Cappuccino";
}
