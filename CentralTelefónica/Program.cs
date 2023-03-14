using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefónica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int numL = 0;
            int numP = 0;

            Console.WriteLine("Cuántas llamadas desea hacer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Que tipo de llamada desea hacer: ");
                Console.WriteLine("A) Llamada Local  B) Llamada fuera de provincia");
                string input = Console.ReadLine();

               
                if (input == "A" | input == "a")
                {
                    llamadasL llamadaLocal = new llamadasL();
                    Console.WriteLine(llamadaLocal.llamadaLocal());
                    numL = numL + 1;
                    total = total + 15;
                }
                if(input == "B" | input == "b")
                {
                    LlamadasP llamadaFuera = new LlamadasP();
                    numP = numP + 1;
                    Console.WriteLine("Que tan lejos será su llamada?");
                    Console.WriteLine("A) franja 1  B) franja 2  C) franja 3");
                    string input2 = Console.ReadLine();

                    if (input2 == "A" | input2 == "a")
                    {
                        Console.WriteLine(llamadaFuera.llamadaP20());
                        total = total + 20;
                    }
                    if (input2 == "B" | input2 == "b")
                    {
                        Console.WriteLine(llamadaFuera.llamadaP25());
                        total = total + 25;
                    }
                    if (input2 == "C" | input2 == "c")
                    {
                        Console.WriteLine(llamadaFuera.llamadaP30());
                        total = total + 30;
                    }
                }
            }
            int numT = numL + numP;
            Console.WriteLine($"Usted realizó {numT} llamadas");
            Console.WriteLine($"Su total es: {total}");
        }
    }
}
