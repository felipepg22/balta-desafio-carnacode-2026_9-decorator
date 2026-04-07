using DesignPatternChallenge.Models;
using DesignPatternChallenge.Models.Decorators;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Pedidos - Cafeteria ===\n");
            
            Console.WriteLine("--- Pedidos com classes específicas ---");
            
            var coffe1 = new CoffeeDecorator(new Espresso());
            Console.WriteLine($"{coffe1.GetDescription()}: R$ {coffe1.GetCost():N2}");
            
            var coffe2 = new MilkDecorator(coffe1);
            Console.WriteLine($"{coffe2.GetDescription()}: R$ {coffe2.GetCost():N2}");

            var coffee3 = new ChocolateDecorator(coffe2);
            Console.WriteLine($"{coffee3.GetDescription()}: R$ {coffee3.GetCost():N2}");

            var coffee4 = new ChantillyDecorator(new ChocolateDecorator(new MilkDecorator(new Cappuccino())));

            Console.WriteLine($"{coffee4.GetDescription()}: R$ {coffee4.GetCost():N2}");

            // Problema: Cliente pode esquecer de setar flags
            var coffee5 = new Espresso();
            // Esqueci de configurar os complementos
            Console.WriteLine($"{coffee5.GetDescription()}: R$ {coffee5.GetCost():N2}");
        }
    }
}
