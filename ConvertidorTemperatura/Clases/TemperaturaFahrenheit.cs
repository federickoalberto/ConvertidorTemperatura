using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorTemperatura.Clases
{
    public class TemperaturaFahrenheit
    {
        public double resultadoCelsius { get; set; }
        public double ConvertirACelsius(double valorFahrenheit)
        {
            resultadoCelsius = (valorFahrenheit - 32) * 5 / 9;
            return resultadoCelsius;
        }
    }
}
