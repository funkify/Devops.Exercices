using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Factoriel : ICommand
    {
        public string Name => "factoriel";

        public void Execute()
        {
            int number = 4; // le nombre dont on veut calculer le factoriel

         

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Le factoriel de {number} est {factorial}");
        }
    }
}
