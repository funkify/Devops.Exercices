using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class IterationDouble : ICommand
    {
        public string Name => "Iteration Double";

        public void Execute()
        {


            for(decimal i = 0; i <= 20; i += 0.1M )
            {
                
                Console.WriteLine(i);

            }
        }
    }
}
