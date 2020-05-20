using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Matiere : IEditable
    {
        internal String codeMatiere;
        internal String nomMatiere;

        public Matiere(string codeMatiere, string nomMatiere)
        {
            this.codeMatiere = codeMatiere;
            this.nomMatiere = nomMatiere;
        }


        public override string ToString()
        {
            string res = "Matiere --> ";
            res += "CodeMatiere : " + codeMatiere;
            res += "NomMatiere : " + nomMatiere;
            return res;
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