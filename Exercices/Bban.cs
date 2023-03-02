using Logique;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Bban : ICommand
    {
        public string Name => "04 - Bban";

        public void Execute()
        {
            string bban; 
            int tenFirstChar, twoLastChar;
            int test;
            double ibanInt;
            bool check;

            bban = Console.ReadLine();

            tenFirstChar = int.Parse((bban.Substring(0, 10)));
            twoLastChar = int.Parse((bban.Substring(10, 2)));


            if (tenFirstChar % 97 == twoLastChar)
            {
                Console.WriteLine("ok");
            }
            else if (tenFirstChar % 97 == 0 && twoLastChar == 97) 
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("ko");
            }


            Console.WriteLine(tenFirstChar);
            Console.WriteLine(twoLastChar);


            // Déplacer les 4 caractères à droite du numéro
            string iban = bban + "111400";
            ibanInt = double.Parse(iban);
            ibanInt = ibanInt % 97;
            ibanInt = 98 - ibanInt;




 
            Console.WriteLine(ibanInt); 






        }
    }
} 