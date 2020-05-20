using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Eleve : Intervenant
    {
        int promo;

        public Eleve(string nom, string prenom, string email, int promo)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.promo = promo;
        }


        public override string ToString()
        {
            string res = "Eleve --> "; 
            res += "Nom : " + nom;
            res += ", Prenom : " + prenom;
            res += ", Email : " + email;
            res += ", Promo : " + promo;
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