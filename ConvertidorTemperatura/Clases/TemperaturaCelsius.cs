using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorTemperatura.Clases
{
    public class TemperaturaCelsius
    {
        public double valorCelsius { get; set; }
        public double resultadoFahrenheit { get; set; }
        public double ConvertirAFahrenheit(double valorCelsius)
        {
            resultadoFahrenheit = (valorCelsius * 9 / 5) + 32;
            return resultadoFahrenheit;
        }
    }
}
