using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PracticaHerencia
{
    public class Burger
    {
        public string Bread { get; set; }
        public string Meat { get; set; }
        public int Price { get; set; }
        public List<(string ingrediente , int priceI)> ingredientes;
        

        public Burger(string bread, string meat, int price)
        {
            Bread = "Sobao";
            Meat = "Angus";
            Price = 250;
            ingredientes = new List<(string,  int)>();
        }
       public void AddI(string ingrediente , int priceI)
        {
            if(ingredientes.Count < 4)
            {
                ingredientes.Add((ingrediente, priceI));
            }
            else
            {
                Console.WriteLine("No se pueden agregar más");
            }
        }
        public void PrecioT()
        {
            int total = Price;
            Console.WriteLine($"Usted quiere una hamburguesa con pan {Bread}, carne {Meat}, y con los siguientes toppings: ");
            foreach((string ingrediente , int priceI) in ingredientes)
            {
                Console.WriteLine(ingrediente );
                total += priceI;
            }
            Console.WriteLine($"Su total es: {total}");
        }
    }
}
