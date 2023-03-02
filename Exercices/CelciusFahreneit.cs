using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class CelciusFahreneit : ICommand
    {
        public string Name => "Celcius et Fahreneit";

        public struct Celcius
        {
            public double Temperature;

            public double FToCConv()
            {
                double result = (Temperature - 32) * (5.0 / 9.0);
                return result;
            }

        }
        public struct Fahrenheit
        {
            public double Temperature;
            public double CToFConv()
            {
                double result = (Temperature * (9.0 / 5.0)) + 32;
                return result;
            }

        }

        public void Execute()
        {
            Celcius celcius = new Celcius();
            Fahrenheit fahrenheit = new Fahrenheit();

            celcius.Temperature  = 220;
            fahrenheit.Temperature = 37;

            double temperatureCelc = celcius.FToCConv();
            double temperatureFahr = fahrenheit.CToFConv();

            Console.WriteLine(celcius.Temperature);
            Console.WriteLine(fahrenheit.Temperature);
            Console.WriteLine(temperatureCelc);
            Console.WriteLine(temperatureFahr);


        }
    }
}
