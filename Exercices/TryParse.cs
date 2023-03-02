using Logique;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    public class TryParse : ICommand
    {
        public string Name => "01_TryParse";
        public void Execute()
        {
            int a, result, b = 0;
            bool test;

            test = int.TryParse(Console.ReadLine(), out a);
            if(!test)
            {
                Console.WriteLine("Entrez un int");
            }

            test = int.TryParse(Console.ReadLine(), out b);

            if(!test)
            {
                Console.WriteLine("Entrez un int");
            }



        }
    }
}
