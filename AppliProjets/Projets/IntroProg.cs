using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class IntroProg : Projet
    {
        public IntroProg(int anneeScolaire, DateTime dateDebut, Sujet suj)
        {
            this.duree = 3*30; //3 mois environ 
            this.anneeScolaire = anneeScolaire;
            this.dateDebut = dateDebut;
            this.nbreEtudiants = 2;
            this.promo = Promo.premiereAnnee;
            this.sujet = suj;

            this.livrables = new List<Livrable>(); //faire en sorte d'ajouter les livrables ici parce que
            //c'est toujours les mêmes ?

            Rapport rap = new Rapport("Rapport IntroProg", 30);
            CodeSource code = new CodeSource("Projet", "C#");
            livrables.Add(rap);
            livrables.Add(code);
        }

        public override string ToString()
        {
            string res = "      Projet IntroProg = ";
            res += ", \nDuree : " + this.duree.ToString();
            res += ", \nAnneeScolaire : " + this.anneeScolaire.ToString();
            res += ", \nDateDebut : " + this.dateDebut.ToString();
            res += ", \nPromo : " + this.promo.ToString();
            res += ", \n" + this.sujet.ToString();
            res += ", \nNbreEtudiants : " + this.nbreEtudiants.ToString();
            res += ", \n";
            foreach (Eleve elv in etudiants)
            {
                res += elv.ToString() + "\n";
            }
            if (etudiants.Count < nbreEtudiants)
            { 
                res += "+ " + (nbreEtudiants - etudiants.Count) + " autres (informations manquantes)\n"; 
            }
            foreach (Livrable livr in livrables)
            {
                res += livr.ToString() + "\n";
            }

            return res;
        }



        public override void Ajouter(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Modifier(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Supprimer(object obj)
        {
            throw new NotImplementedException();
        }
    }
}