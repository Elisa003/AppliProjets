using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public abstract class Intervenant: IEditable
    {
        protected String nom;
        protected String prenom;
        protected String email;



        public abstract void Ajouter(object obj);
        public abstract void Modifier(object obj);
        public abstract void Supprimer(object obj);
    }
}