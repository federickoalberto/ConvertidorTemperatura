using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertidorTemperatura.Clases;

namespace ConvertidorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("\t\t\tConvertidor Temperatura");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("\n----------------------------------------------------------------------");
                Console.WriteLine("\t\t\t\tMenú");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("\t\t1.- Convertir de Farenheit a Celsius");
                Console.WriteLine("\t\t2.- Convertir de Celsius a Farenheit");
                Console.WriteLine("\t\t3.- Salir");

                int op = 0;

                Console.WriteLine("\nElija una opcion");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {

                    case 1:

                        Console.WriteLine("\nIngrese la temperatura en grados Farenheit:");
                        double farenheit = Convert.ToDouble(Console.ReadLine());

                        TemperaturaFahrenheit temperaturaFarenheit = new TemperaturaFahrenheit();

                        Console.WriteLine("\nLa temperatura en Celsius es: " + 
                            temperaturaFarenheit.ConvertirACelsius(farenheit) + " grados");

                        Console.WriteLine("\nPresione una tecla para continuar...");

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:

                        Console.WriteLine("\nIngrese la temperatura en grados Celsius:");
                        double celsius = Convert.ToDouble(Console.ReadLine());

                        TemperaturaCelsius temperaturaCelsius = new TemperaturaCelsius();

                        Console.WriteLine("\nLa temperatura en Farenheit es: " + 
                            temperaturaCelsius.ConvertirAFahrenheit(celsius) + " grados");

                        Console.WriteLine("\nPresione una tecla para continuar...");

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 3:

                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}
