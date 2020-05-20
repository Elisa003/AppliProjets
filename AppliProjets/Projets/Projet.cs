using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AppliProjets
{
    public abstract class Projet : IEditable
    {
        protected int nbPersonnesImpliquees; //utile pour quoi ?
        protected int duree; //temps en jours
        protected int anneeScolaire;
        protected DateTime dateDebut;
        protected int nbreEtudiants;

        //Program.cs ne fonctionne pas avec le get et le set mais avec cette ligne-là oui... mystère
        protected List<Eleve> etudiants = new List<Eleve>();
        protected List<Livrable> livrables = new List<Livrable>();
        protected List<Matiere> matieres = new List<Matiere>();
        public Promo promo
        {
            get => default;
            set { }
        }
        public Sujet sujet
        {
            get { return new Sujet(); }
            set { }
        }
        //public List<Eleve> etudiants
        //{
        //    get { return new List<Eleve>(); }
        //    set { }
        //}
        //public List<Matiere> matieres
        //{
        //    get { return new List<Matiere>(); }
        //    set { }
        //}
        //public List<Livrable> livrables
        //{
        //    get { return new List<Livrable>(); }
        //    set { }
        //}


        public void SauvegardeProjet()
        {
            try
            {
                //Ecrit à la suite du fichier
                using System.IO.StreamWriter file = new System.IO.StreamWriter("../../../../SauvProjets.txt", true);
                file.WriteLine("*==" + this.ToString() + "==*");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue au cours de la sauvegarde du projet");
                Console.WriteLine(ex.Message);
            }

        }

        public void RechercheParEleve(Eleve eleve)
        {
            Encoding encoding = Encoding.GetEncoding("iso-8859-1");
            StreamReader monStreamReader = new StreamReader("../../../../SauvProjets.txt", encoding);

            using StreamWriter file = new StreamWriter("../../../../ResultRech.txt", true);

            string line = monStreamReader.ReadLine();

            //Lecture de chaque ligne
            while(line != null)
            {
                //Si la ligne contient l'élève, on récupère tout le projet 
                if (line.Contains(eleve.ToString()))
                {
                    file.WriteLine("*==");
                    //Console.WriteLine("====== J'ai ! =======");
                    while (!line.Contains("==*")) //Récupère la fin du projet (entre le moment où est écrit l'élève et *==
                    {
                        file.WriteLine(line);
                        line = monStreamReader.ReadLine();
                    }
                    file.WriteLine("==*");
                }
                line = monStreamReader.ReadLine();
            }

        }

        

        //Méthodes à appeler dans chaque sous-projet (dans le constructeur ?)
        public void AjouterEleve(params Eleve[] eleves)
        {
            foreach (Eleve elv in eleves)
                etudiants.Add(elv);
        }
        public void AjouterLivrable(params Livrable[] livs)
        {
            foreach (Livrable liv in livs)
                livrables.Add(liv);
        }
        public void AjouterMatiere(params Matiere[] mats)
        {
            foreach (Matiere mat in mats)
                matieres.Add(mat);
        }






        public abstract void Ajouter(object obj);
        public abstract void Modifier(object obj);
        public abstract void Supprimer(object obj);
    }
}