using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Matiere : IEditable
    {
        String codeMatiere;
        String nomMatiere;

        public Matiere(string codeMatiere, string nomMatiere)
        {
            this.codeMatiere = codeMatiere;
            this.nomMatiere = nomMatiere;
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