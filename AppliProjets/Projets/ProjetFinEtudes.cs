using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class ProjetFinEtudes : Projet
    {
        Intervenant tuteur;

        public ProjetFinEtudes(Intervenant tuteur, int anneeScolaire, DateTime dateDebut, Sujet suj)
        {
            this.tuteur = tuteur;
            this.duree = 30 * 3; //je sais pas cb de temps ça dure mdr
            this.anneeScolaire = anneeScolaire;
            this.dateDebut = dateDebut;
            this.promo = Promo.troisiemeAnnee;
            this.sujet = suj;
            this.nbreEtudiants = 1;
        }

        public override string ToString()
        {
            string res = "Projet Transpromo = ";
            res += ", \nTuteur : " + this.tuteur.ToString();
            res += ", \nDuree : " + this.duree.ToString();
            res += ", \nAnneeScolaire : " + this.anneeScolaire.ToString();
            res += ", \nDateDebut : " + this.dateDebut.ToString();
            res += ", \nPromo : " + this.promo.ToString();
            res += ", \n" + this.sujet.ToString();
            res += ", \nNbreEtudiants : " + this.nbreEtudiants.ToString();
            res += ", \n";
            res += etudiants[0].ToString() + "\n"; //vu qu'il y a qu'un seul étudiant je pense que ça suffit
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