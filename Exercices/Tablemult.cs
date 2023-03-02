using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Tablemult : ICommand
    {
        public string Name => "table de multiplication";

        public void Execute()
        {
            int nbr1, nbr2, rep;
            for (nbr1 = 1; nbr1 <= 5; nbr1++)
            {
                for (nbr2 = 1; nbr2 <= 20; nbr2++)
                {
                    rep = nbr1 * nbr2;
                    Console.WriteLine("{0} x {1} = {2}", nbr1, nbr2, rep);
                }
            }
        }
    }
}
