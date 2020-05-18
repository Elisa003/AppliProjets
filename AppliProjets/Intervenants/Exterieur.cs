using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Exterieur : Intervenant
    {
        String organisation;

        public Exterieur(string nom, string prenom, string email, string organisation)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.organisation = organisation;
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