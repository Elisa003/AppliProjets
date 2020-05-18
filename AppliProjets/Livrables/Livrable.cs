using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public abstract class Livrable : IEditable
    {
        protected String nom;

        public abstract void Ajouter(object obj);
        public abstract void Modifier(object obj);
        public abstract void Supprimer(object obj);
    }
}