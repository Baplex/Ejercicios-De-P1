﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    public class BurgerP : Burger
    {
        public BurgerP(string bread, string meat, int price) : base(bread, meat, price)
        {
            
            Bread = "Brioche";
            Meat = "Angus Premium";
            Price = 400;
        }
      
        public void AddI()
        {
            Console.WriteLine("No puede agregar toppings.");
        }
        public new void PrecioT()
        {
            int total = Price;
            Console.WriteLine($"Usted quiere una hamburguesa con pan {Bread}, carne {Meat}, con papas y una bebida");
            Console.WriteLine($"Su total es: {total}");
        }

    }
}
