using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ej._1
{
    public class Coche
    {
        private Motor motor{ get; set; } 
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public double Precio_A { get; set; }

        public Coche(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void AcumularA(int precio_A)
        {
            Precio_A = precio_A ++;
        }
    }
}
