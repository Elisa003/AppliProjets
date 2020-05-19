using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Rapport : Livrable
    {
        int nbPagesMax;

        public Rapport(string nom, int nbPagesMax)
        {
            this.nom = nom;
            this.nbPagesMax = nbPagesMax;
        }
        public override string ToString()
        {
            string res = "Rapport = ";
            res += "Nom : " + nom;
            res += ", NbPagesMax : " + nbPagesMax;

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