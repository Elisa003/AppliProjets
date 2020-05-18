using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class IntroProg : Projet
    {
        public IntroProg(int anneeScolaire, DateTime dateDebut, int nbreEtudiants)
        {
            this.duree = 3*30; //3 mois environ ?
            this.anneeScolaire = anneeScolaire;
            this.dateDebut = dateDebut;
            this.nbreEtudiants = nbreEtudiants;
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