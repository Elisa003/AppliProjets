using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public abstract class Intervenant: IEditable
    {
        internal String nom;
        internal String prenom;
        internal String email;



        public abstract void Ajouter(object obj);
        public abstract void Modifier(object obj);
        public abstract void Supprimer(object obj);
    }
}