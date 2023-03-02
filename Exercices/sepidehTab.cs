using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class sepidehTab : ICommand
    {
        public string Name => "Sepieh tab";

        public void Execute()
        {
            int lenght = 10 , width = 10;
            string[,] bord = new string[lenght, width];

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bord[i, j] = "#";
                    Console.Write("{0,-2}", bord[i, j]);
                }
                Console.WriteLine();


            }
        }
    }
    
}
