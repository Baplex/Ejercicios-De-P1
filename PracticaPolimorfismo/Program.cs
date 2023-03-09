using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BorderCollie Collie1 = new BorderCollie();
            Pug pug1 = new Pug();
            


            Console.WriteLine("Qué raza de perro desea?: ");
            Console.WriteLine("A) Border Collie"+ " B) Pug");
            string raza = Console.ReadLine();

            if(raza == "A" | raza == "a")
            {
                Perro[] Pierro = { Collie1 };
                Console.WriteLine($"Decida que está haciendo su perro: ");
                Console.WriteLine("A) Ladrar" +
                    " B) Comer" +
                    " C) Dormir" +
                    " D) Jugar" +
                    " E) Caminar" +
                    " F) Veterinario");

                string input = Console.ReadLine();
                foreach (Perro i in Pierro)
                {
                    if (input == "A" | input == "a")
                    {
                        Console.WriteLine(i.bark());
                    }
                    if (input == "B" | input == "b")
                    {
                        Console.WriteLine(i.eat());
                    }
                    if (input == "C" | input == "c")
                    {
                        Console.WriteLine(i.slep());
                    }
                    if (input == "D" | input == "d")
                    {
                        Console.WriteLine(i.play());
                    }
                    if (input == "E" | input == "e")
                    {
                        Console.WriteLine(i.walk());
                    }
                    if (input == "F" | input == "f")
                    {
                        Console.WriteLine(i.vet());
                    }
                }
            }
            if (raza == "B" | raza == "b")
            {
                Perro[] Pierro = { pug1 };
                Console.WriteLine($"Decida que está haciendo su perro: ");
                Console.WriteLine("A) Ladrar" +
                    " B) Comer" +
                    " C) Dormir" +
                    " D) Jugar" +
                    " E) Caminar" +
                    " F) Veterinario");

                string input = Console.ReadLine();
                foreach (Perro i in Pierro)
                {
                    if (input == "A" | input == "a")
                    {
                        Console.WriteLine(i.bark());
                    }
                    if (input == "B" | input == "b")
                    {
                        Console.WriteLine(i.eat());
                    }
                    if (input == "C" | input == "c")
                    {
                        Console.WriteLine(i.slep());
                    }
                    if (input == "D" | input == "d")
                    {
                        Console.WriteLine(i.play());
                    }
                    if (input == "E" | input == "e")
                    {
                        Console.WriteLine(i.walk());
                    }
                    if (input == "F" | input == "f")
                    {
                        Console.WriteLine(i.vet());
                    }
                }
            }
            

        }
    }
}
