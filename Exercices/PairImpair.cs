using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    public class PairImpair : ICommand
    {
        public string Name => "02 Paire/Impaire";

        public void Execute()
        {
            int nb;
            nb = int.Parse(Console.ReadLine());

            if(nb / 2 + nb /2 == nb  )
            {
                Console.WriteLine("Le nombre est paire");
            }
            else
            {
                Console.WriteLine("le nombre est impaire");
            }




             
        }
    }
}
