using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class TableauQuartdeTour : ICommand
    {
        public string Name => "Quart de tour";

        public void Execute()
        {

            static void CreateBoard(int sizeX, int sizeY, bool quart = false)
            {
                int[,] board = new int[sizeX, sizeY];


                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = 0; j < sizeY; j++)
                    {
                        if (!quart)
                        {
                            board[i, j] = j;
                            Console.Write($" {board[i, j]}");
                        }
                        else
                        {
                            board[i, j] = i;
                            Console.Write($" {board[i, j]}");
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Premier tableau");
            CreateBoard(10,10);
            Console.WriteLine("Tableau avec quart de tour");
            CreateBoard(10,10, true);


        }
    }
}
