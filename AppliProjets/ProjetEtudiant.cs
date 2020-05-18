using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{

    // à ne pas garder je pense
    public class ProjetEtudiant : Projet
    {
        int anneeScolaire;
        List<Eleve> etudiants;
        Sujet sujet;

        public Sujet Sujet
        {
            get => default;
            set
            {
            }
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