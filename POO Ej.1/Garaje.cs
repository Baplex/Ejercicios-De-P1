﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ej._1
{
    public class Garaje
    {
        public Coche coche {  get; set; }

        public string Averia_A { get; set; }

        public int Num_Coche { get; set; }

      public void Aceptar_C(int Num_Coche, int averia)
        {

            bool z = true;
            if (Num_Coche > 1)
            {
                Console.WriteLine("El garaje está lleno.");
                z = false;
            }
        }

        public void Devolver_C(int Num_Coche, int averia)
        {
            if (Num_Coche > 1)
            {
                Num_Coche = Num_Coche -1;
            }
        }
    }
}
