using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamenFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            startConductor:
            Console.WriteLine("");
            Console.WriteLine("Ingrese los datos del conductor ");
            Conductor conductor = new Conductor();

            Console.WriteLine("Nombre: ");
            conductor.Name = Console.ReadLine();

            Console.WriteLine("Cedula: ");
            conductor.Cedula = Console.ReadLine();

            Console.WriteLine("Dirección: ");
            conductor.Direccion = Console.ReadLine();

            Console.WriteLine("Tipo de Licencia: ");
            conductor.Licencia = Console.ReadLine();

            Console.WriteLine("Fecha de Nacimiento: ");
            conductor.Fecha = Console.ReadLine();

            if (string.IsNullOrEmpty(conductor.Name) || string.IsNullOrEmpty(conductor.Direccion) || string.IsNullOrEmpty(conductor.Licencia) || string.IsNullOrEmpty(conductor.Fecha) || string.IsNullOrEmpty(conductor.Cedula))
            {
                Console.WriteLine("Uno o más parametros están vacios. Intente de nuevo.");
                goto startConductor;
            }

            Console.WriteLine("");


            startAgente:
            Console.WriteLine("");
            Console.WriteLine("Ingrese los datos del Agente ");
            Agente agente = new Agente();

            Console.WriteLine("Nombre: ");
            agente.Name = Console.ReadLine();

            Console.WriteLine("Identificación: ");
            agente.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dirección: ");
            agente.Direccion = Console.ReadLine();

            Console.WriteLine("Fecha de Infracción: ");
            agente.FechaI = Console.ReadLine();

            if (string.IsNullOrEmpty(agente.Name) || string.IsNullOrEmpty(agente.Direccion) || string.IsNullOrEmpty(agente.FechaI))
            {
                Console.WriteLine("Uno o más parametros están vacios. Intente de nuevo.");
                goto startAgente;
            }

            Console.WriteLine("");

            startVehiculo:
            Console.WriteLine("");
            Console.WriteLine("Ingrese los datos del vehículo ");
            Vehiculo carro = new Vehiculo();

            Console.WriteLine("Indique la placa del vehículo: ");
            carro.Placa = Console.ReadLine();

            Console.WriteLine("Indique la marca del vehículo: ");
            carro.Marca = Console.ReadLine();

            Console.WriteLine("Indique el modelo del vehículo: ");
            carro.Modelo = Console.ReadLine();

            Console.WriteLine("Indique el color del vehículo: ");
            carro.Color = Console.ReadLine();

            Console.WriteLine("Indique el año del vehículo: ");
            carro.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique el número de chasis del vehículo: ");
            carro.NumChasis = Convert.ToInt32(Console.ReadLine());


            if (string.IsNullOrEmpty(carro.Placa) || string.IsNullOrEmpty(carro.Marca) || string.IsNullOrEmpty(carro.Modelo) || string.IsNullOrEmpty(carro.Color) ) 
            {
                Console.WriteLine("Uno o más parametros están vacios. Intente de nuevo.");
                goto startVehiculo;
            }

            Console.WriteLine("");

            Console.WriteLine("Indique cuantas infracciones se han cometidas: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Infracciones penalidad = new Infracciones(0);
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Indique la Infracción cometida: ");
                Console.WriteLine("A) Obstrucción de Transito");
                Console.WriteLine("B) Cruzar Luz Roja");
                Console.WriteLine("C) Conducir mientras habla por móvil");
                Console.WriteLine("D) Licencia Vencida");
                string inp = Console.ReadLine();
                if(inp == "A" | inp == "a")
                {
                    penalidad.ObsTran();
                }
                if (inp == "B" | inp == "b")
                {
                    penalidad.Rojo();
                }
                if (inp == "C" | inp == "c")
                {
                    penalidad.Cel();
                }
                if (inp == "D" | inp == "d")
                {
                    penalidad.LicVen();
                }

            }

            penalidad.Total();
        }
    }
}
