using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercices
{
    public struct Point
    {
        public int x, y;

    }

    internal class Structure : ICommand
    {
        public string Name => "structures";

        public void Execute()
        {
            Point?[,] point2Dim = new Point?[5,5];

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        point2Dim[i,j] = new Point {x = i+1,y = i+1};
                        Console.Write($"X : {point2Dim[i,j]?.x}");
                        Console.Write($" - Y : {point2Dim[i,j]?.y}");
                    }
                    else
                    {

                        point2Dim[i,j] = new Point {x = 0,y = 0};
                        Console.Write($"  ");
                        Console.Write($"  ");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
