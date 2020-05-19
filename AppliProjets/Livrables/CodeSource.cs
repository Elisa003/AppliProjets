using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class CodeSource : Livrable
    {
        String langage;

        public CodeSource(string nom, string langage)
        {
            this.nom = nom;
            this.langage = langage;
        }

        public override string ToString()
        {
            string res = "CodeSource = ";
            res += "Nom : " + nom;
            res += ", Langage : " + langage;

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