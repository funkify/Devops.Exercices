using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Nbpremier : ICommand
    {
        public string Name => "nbrepremier";

        public void Execute()
        {
            int x = 6;
            int compteur = 0;
            int num = 2;

            Console.WriteLine($"Les {x} premiers nombres premiers sont :");

            for (compteur = 0; compteur < x;)
            {
                bool premier = true;

                for (int i = 2; i <= Math.Sqrt(num) && premier ; i++)
                {
                    if (num % i == 0)
                    {
                        premier = false;
                    }
                }


                if (premier)
                {
                    compteur++;
                }

                num++;

            }
            
           Console.Write($"{num - 1 } ");
        }
    }
}
