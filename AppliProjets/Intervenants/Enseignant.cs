using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public class Enseignant : Intervenant
    {
        List<Matiere> matiereEnseignee;

        public Enseignant(string nom, string prenom, string email, List<Matiere> matiereEnseignee)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.matiereEnseignee = matiereEnseignee;
        }

        public override string ToString()
        {
            string res = "Enseignant = ";
            res += "Nom : " + nom;
            res += ", Prenom : " + prenom;
            res += ", Email : " + email;
            res += ", MatiereEnseignee : ";

            foreach (Matiere mat in matiereEnseignee)
            {
                res += mat.codeMatiere + " " + mat.nomMatiere + ", ";
            }
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