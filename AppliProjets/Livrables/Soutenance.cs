using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Soutenance : Livrable
    {
        int duree;

        public Soutenance(string nom, int duree)
        {
            this.nom = nom;
            this.duree = duree;
        }

        public override string ToString()
        {
            string res = "Soutenance = ";
            res += "Nom : " + nom;
            res += ", Duree : " + duree;

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