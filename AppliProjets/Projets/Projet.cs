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
        public Promo promo
        {
            get => default;
            set { }
        }
        public Sujet sujet
        {
            get => default;
            set { }
        }
        public List<Eleve> etudiants
        {
            get => default;
            set { }
        }
        public List<Matiere> matieres
        {
            get => default;
            set { }
        }
        public List<Livrable> livrables
        {
            get => default;
            set { }
        }


        public static void SauvegardeProjet(string fichier_cible, Projet proj)
        {
            try
            {
                //Création d'une instance de StreamWritter pour permettre l'écriture dans notre fichier cible
                StreamWriter monStreamWritter = File.CreateText(fichier_cible);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue au cours de la sauvegarde du projet");
                Console.WriteLine(ex.Message);
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