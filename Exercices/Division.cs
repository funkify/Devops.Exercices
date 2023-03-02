using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Division : ICommand
    {
        public string Name => "Division/Modulo";

        public void Execute()
        {
            int a, b;
            bool parse; 
            parse = int.TryParse(Console.ReadLine(), out a);
            parse = int.TryParse(Console.ReadLine(), out b);


            Console.WriteLine($"{a} / {b} = {(decimal)a/b}, {a} % {b} = {a % b} ");
        }
    }
}
