using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    public class BurgerH : Burger
    {
        public BurgerH(string bread, string meat, int price) : base(bread, meat, price)
        {
            Bread = "Integral";
            Meat = "Alternativa Saludable";
            Price = 260;
        }
        public new void AddI(string ingrediente, int priceI)
        {
            if (ingredientes.Count < 6)
            {
                ingredientes.Add((ingrediente, priceI));
            }
            else
            {
                Console.WriteLine("No se pueden agregar más");
            }
        }
        public new void PrecioT()
        {
            int total = Price;
            Console.WriteLine($"Usted quiere una hamburguesa con pan {Bread}, carne {Meat}, y con los siguientes toppings: ");
            foreach ((string ingrediente, int priceI) in ingredientes)
            {
                Console.WriteLine(ingrediente);
                total += priceI;
            }
            Console.WriteLine($"Su total es: {total}");
        }
    }
}
