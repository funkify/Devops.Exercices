using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Fibonnacci : ICommand
    {
        public string Name => "05 - Fibonnacci"; 
        public void Execute()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Entrer le nombre d'éléments: ");
            number = int.Parse(Console.ReadLine());
            Console.Write($"{n1} {n2} ");

            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
