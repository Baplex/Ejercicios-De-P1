using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ej._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garaje garaje = new Garaje();
            Coche coche = new Coche("BMW", "M3");
            Coche coche1 = new Coche("Mazda", "Miata");
            //Tests//
            //Console.WriteLine(coche.Marca);
            //Console.WriteLine(coche1.Marca);    
            //Console.WriteLine(coche.Modelo);
            //Console.WriteLine(coche1.Modelo);
            //Tests//

            Console.ReadKey();
        }
    }
}
