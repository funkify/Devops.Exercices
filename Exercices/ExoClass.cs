using Logique;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class ExoClass : ICommand
    {
        public string Name => "Entraînement class";

        public class CompteBancaire
        {
            private string titulaire;
            private decimal solde;
            private string devise;

            public CompteBancaire(string leTitulaire, decimal leSolde, string laDevise)
            {
                titulaire = leTitulaire;
                solde = leSolde;
                devise = laDevise;
            }

            public string Titulaire { get; set; }
            public decimal Solde { get; set; }
            public string Devise { get; set; }

            public void Crediter(decimal montant)
            {
                solde += montant;
            }
            public void Debiter(decimal montant)
            {
                solde -= montant;
            }
            
            public string Decrire()
            {
                string description = $"Le solde du compte de {titulaire} est de {solde} {devise}";
                return description;
            }
        }


        public void Execute()
        {
            CompteBancaire compteMarc = new CompteBancaire("Marc", 0, "euros");
            Console.WriteLine(compteMarc.Decrire());
        }
    }
}
