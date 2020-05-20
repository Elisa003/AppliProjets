using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Transdisciplinaire : Projet
    {

        Intervenant client;
        Intervenant tuteur;

        public Transdisciplinaire(Intervenant client, Intervenant tuteur, int anneeScolaire, DateTime dateDebut, Sujet sujet, int nbreEtudiants)
        {
            this.client = client;
            this.tuteur = tuteur;
            this.duree = 30 * 8; //environ 8 mois ?
            this.anneeScolaire = anneeScolaire;
            this.dateDebut = dateDebut;
            this.promo = Promo.premiereAnnee;
            this.sujet = sujet;
            this.nbreEtudiants = nbreEtudiants;
        }

        public override string ToString()
        {
            string res = "      Projet Transdisciplinaire = ";
            res += "\nClient : " + this.client.ToString();
            res += ", \nTuteur : " + this.tuteur.ToString();
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