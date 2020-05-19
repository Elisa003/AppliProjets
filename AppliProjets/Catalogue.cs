using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Catalogue
    {
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
                    if (p.promo == promo)
                        return p;
                return null;
            }
        }
    }
}