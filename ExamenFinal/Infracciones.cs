using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Infracciones
    {
        public int Penalidad { get; set; }
        private List<string> notas;
        public Infracciones(int penalidad)
        {
            Penalidad = 0;
            notas = new List<string>();
        }

        public void ObsTran()
        {
            Penalidad = Penalidad + 1800;
            notas.Add("Ha causado una obstrucción de transito");
        }
        public void Rojo()
        {
            Penalidad = Penalidad + 5950;
            notas.Add("Se ha ido en rojo");
        }
        public void Cel()
        {
            Penalidad = Penalidad + 3750;
            notas.Add("Conducía mientras hablaba en su dispositivo móvil");
        }
        public void Cint()
        {
            Penalidad = Penalidad + 2560;
            notas.Add("Conducía sin cinturón");
        }
        public void LicVen()
        {
            Penalidad = Penalidad + 3890;
            notas.Add("Tiene una licencia vencida");
        }
        public void Total()
        {
            if (notas.Count > 0)
            {
                foreach (string notas in notas)
                {
                    Console.WriteLine(notas);
                }
            }

            Console.WriteLine($"Tomando en cuenta todas sus infracciones, le debe pagar al gobierno una suma de ${Penalidad}RD");
            
        }
    }
}
