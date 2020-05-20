using System;
using System.Collections.Generic;
using System.Globalization;
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
                file.WriteLine("*==\n" + this.ToString() + "\n==*\n");
                //*== et ==* symbolisant respectivement le début et la fin d'un projet
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue au cours de la sauvegarde du projet");
                Console.WriteLine(ex.Message);
            }
        }


        //===== A TESTER ======
        public string RecherchePar(Object obj) //obj représente ici un élève, un enseignant, un sujet, une année, une promo ....
            //mais peut aussi être un mot-clé
        {
            //supprime le fichier ResulRech s'il existe
            if (File.Exists("../../../../ResultRech.txt"))
            {
                try
                {
                    File.Delete("../../../../ResultRech.txt");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            Encoding encoding = Encoding.GetEncoding("iso-8859-1");
            StreamReader monStreamReader = new StreamReader("../../../../SauvProjets.txt", encoding);

            using StreamWriter file = new StreamWriter("../../../../ResultRech.txt", true);

            string line = monStreamReader.ReadLine();
            string lineTemp = string.Empty;
            bool peutEcrire = false;

            //Lecture de chaque ligne
            while(line != null)
            {
                //Si la ligne contient l'élève, on récupère tout le projet 
                if (line.Contains(obj.ToString()))
                {
                    peutEcrire = false;
                    //Test
                    //Console.WriteLine("====== J'ai ! =======");

                    //file.WriteLine("*==");//Début d'un projet

                    //Récupère le début du projet (entre *== et le moment où est écrit l'élève
                    file.WriteLine(lineTemp);

                    //Récupère la fin du projet (entre le moment où est écrit l'élève et ==*
                    while (!line.Contains("==*")) 
                    {
                        file.WriteLine(line);
                        line = monStreamReader.ReadLine();
                    }
                    
                    file.WriteLine("==*");//Fin d'un projet

                    lineTemp = string.Empty; //On vide la variable temporaire pour la prochaine boucle
                }

                //Détection du début d'un projet et autorisation de copier les premières lignes
                if (line.Contains("*=="))
                    peutEcrire = true;
                if (peutEcrire)
                    lineTemp += line + "\n";

                //Passage à la ligne suivante
                line = monStreamReader.ReadLine();
            }

            return RecupResulRech(); //doit retourner un string (=résultat de la rechercher) qu'il faut afficher 
        }

        //Reste à faire : FAIT JUSTE EN DESSOUS
        //transférer le contenu du fichier ResultRech dans une variable string pour pouvoir l'afficher 
        // + vider le fichier ResulRech quand on a fini de l'utiliser

        public string RecupResulRech()
        {
            string recupResultat = string.Empty;

            Encoding encoding = Encoding.GetEncoding("iso-8859-1");
            StreamReader monStreamReader = new StreamReader("../../../../ResultRech.txt", encoding);

            string line = monStreamReader.ReadLine();

            while (line != null)
            {
                recupResultat += line;
            }

            return recupResultat;
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