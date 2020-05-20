using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class SiteWeb : Livrable
    {
        String url;

        public SiteWeb(string nom, string url)
        {
            this.nom = nom;
            this.url = url;
        }

        public override string ToString()
        {
            string res = "SiteWeb --> ";
            res += "Nom : " + nom;
            res += ", Url : " + url;

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