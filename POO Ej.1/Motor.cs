using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ej._1
{
    public class Motor
    {
        private int Litros_de_aceite {get; set;}
        private int Potencia {get; set;}

        public Motor(int potencia)
        {
            Potencia = potencia;
            Litros_de_aceite = 0;
        }
        
    }

}
       

