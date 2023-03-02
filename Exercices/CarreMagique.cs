using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class CarreMagique : ICommand
    {
        public string Name => "Carré Magique";

        public void Execute()
        {
            int[,] tableau = {
                { 2, 7, 6 },
                { 9, 5, 1 },
                { 4, 3, 8 },
            };

            bool estCarreMagique = EstCarreMagique(tableau);
            Console.WriteLine("Le tableau est un carré magique ? " + estCarreMagique);
        }

        public static bool EstCarreMagique(int[,] tableau)
        {
            int taille = tableau.GetLength(0);
            int sommeDiagPrincipale = 0;
            int sommeDiagSecondaire = 0;

            // Calculer la somme de la diagonale principale et de la diagonale secondaire
            for (int i = 0; i < taille; i++)
            {
                sommeDiagPrincipale += tableau[i, i];
                sommeDiagSecondaire += tableau[i, taille - i - 1];
            }

            // Vérifier si la somme de chaque ligne, colonne et diagonale est égale à la somme de la diagonale principale
            for (int i = 0; i < taille; i++)
            {
                int sommeLigne = 0;
                int sommeColonne = 0;

                for (int j = 0; j < taille; j++)
                {
                    sommeLigne += tableau[i, j];
                    sommeColonne += tableau[j, i];
                }

                if (sommeLigne != sommeDiagPrincipale || sommeColonne != sommeDiagPrincipale)
                {
                    return false;
                }
            }

            // Vérifier si la somme de la diagonale principale et de la diagonale secondaire est égale
            if (sommeDiagPrincipale != sommeDiagSecondaire)
            {
                return false;
            }

            return true;
        }
    }
}
