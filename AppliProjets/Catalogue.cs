using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Catalogue
    {
        // c'est moi qui ait fait tout ça ? ^^

        Projet[] projets;
        public Catalogue(int nbProjets)
        {
            projets = new Projet[nbProjets];
        }
        public int NombreProjets { get { return projets.Length; } }
        
        public Projet this [Promo promo]
        {
            get {
                foreach (Projet p in projets)
                    if (p.Promo == promo)
                        return p;
                return null;
            }
        }
    }
}