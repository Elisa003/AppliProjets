using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Transpromo : Projet
    {
        
        Intervenant client;
        Intervenant tuteur;

        public Transpromo(Intervenant client, Intervenant tuteur, int anneeScolaire, DateTime dateDebut, Sujet sujet, int nbreEtudiants)
        {
            this.client = client;
            this.tuteur = tuteur;
            this.duree = 30 * 4; //environ 4 mois 
            this.anneeScolaire = anneeScolaire;
            this.dateDebut = dateDebut;
            this.promo = Promo.premiereAnnee;
            this.sujet = sujet;
            this.nbreEtudiants = nbreEtudiants;

        }

        public override void Ajouter(object obj)
        {

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