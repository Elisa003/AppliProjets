﻿using System;
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
        public Exterieur(string nom, string prenom, string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
        }
        public override string ToString()
        {
            string res = "Exterieur --> ";
            res += "Nom : " + nom;
            res += ", Prenom : " + prenom;
            res += ", Email : " + email;
            res += ", Organisation : " + organisation;

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