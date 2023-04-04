using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tipo de hamburguesa desea? ");
            Console.WriteLine("1) Normal  2) Premium  3) Saludable");
            int input = Convert.ToInt32(Console.ReadLine());


            if (input == 1) 
            {
                Burger burger = new Burger("", "", 0);

                Console.WriteLine("Cuantos toppings desea agregar? (máximo 4) ");
                int input1 = Convert.ToInt32(Console.ReadLine());
                
                if(input1 > 4)
                {
                    Console.WriteLine("No puede más de 4");              
                }
                else
                {
                    int precioI = input1 * 20;
                    Console.WriteLine("Escriba sus toppings");

                    for (int i = 0; i < input1; i++)
                    {
                        burger.AddI(Console.ReadLine(), precioI);
                    }

                    burger.PrecioT();
                }
            }

            if (input == 2) 
            {
                BurgerP burgerP = new BurgerP("", "", 0);
                burgerP.PrecioT();
            }
           
            if(input == 3)
            {
                BurgerH burgerH = new BurgerH("", "", 0);

                Console.WriteLine("Cuantos toppings desea agregar? (máximo 6) ");
                int input1 = Convert.ToInt32(Console.ReadLine());

                if (input1 > 6)
                {
                    Console.WriteLine("No puede más de 6");
                }
                else
                {
                    int precioI = input1 * 20;
                    Console.WriteLine("Escriba sus toppings");

                    for (int i = 0; i < input1; i++)
                    {
                        burgerH.AddI(Console.ReadLine(), precioI);
                    }
                    burgerH.PrecioT();
                }

                
            }

        }
    }
}
