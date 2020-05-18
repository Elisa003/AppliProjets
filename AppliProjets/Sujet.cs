using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Sujet : IEditable
    {
        String intitule;
        bool impose;

        public Sujet(string intitule, bool impose)
        {
            this.intitule = intitule;
            this.impose = impose;
        }

        public void Ajouter(object obj)
        {
            throw new NotImplementedException();
        }

        public void Modifier(object obj)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(object obj)
        {
            throw new NotImplementedException();
        }
    }
}