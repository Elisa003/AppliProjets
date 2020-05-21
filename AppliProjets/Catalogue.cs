using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AppliProjets
{
    public class Catalogue
    {
        static Projet[] projets;
        static int nbProjetsRentres;
        public Catalogue(int nbProjets)
        {
            projets = new Projet[nbProjets];
            nbProjetsRentres = 0;
        }


        public int NombreProjets { get { return projets.Length; } }


        public Projet[] Liste() { return projets; }

        public static void AjouterProjet(Projet projet) //ajouter le constructeur ?
        {
            if (nbProjetsRentres < projets.Length)
            {
                projets[nbProjetsRentres] = projet;
                nbProjetsRentres++;
            }
            else
            {
                Projet[] projets2 = new Projet[projets.Length + 1];
                nbProjetsRentres = 0;
                foreach (Projet proj in projets)
                {
                    projets2[nbProjetsRentres] = proj;
                    nbProjetsRentres++;
                }
                projets2[nbProjetsRentres] = projet;
                nbProjetsRentres++;
                projets = projets2;
            }
            projet.SauvegardeProjet();
            Console.WriteLine("Le projet a été enregistré avec succés !\n");
        }


        public static void ApproCatalogue()
        {
            //Ajout des matières
            Matiere introProg = new Matiere("CO5SFIN0", "Introduction à la programmation");
            Matiere infoComBBWeb = new Matiere("CO5SFBD0", "Information et communication, bases de données et programmation web");
            Matiere transdi = new Matiere("CO5PRTD0", "Projets transdisciplinaires de l'ENSC");
            Matiere bioHumaine = new Matiere("CO5SCBIO", "Bases biologie humaine");
            Matiere gesP = new Matiere("CO6INGP0", "Gestion de projet et conception");
            Matiere gcco = new Matiere("CO6SCCC0", "Gestion des connaissances et des compétences");
            Matiere progAv = new Matiere("CO6SFPA0", "Programmation avancée");
            Matiere commWeb = new Matiere("CO6SFCX0", "Communication web");

            List<Matiere> infoWeb = new List<Matiere>();
            infoWeb.Add(introProg);
            infoWeb.Add(infoComBBWeb);

            List<Matiere> projets1A = new List<Matiere>();
            projets1A.Add(transdi);

            List<Matiere> GCCo = new List<Matiere>();
            GCCo.Add(gcco);

            List<Matiere> bio = new List<Matiere>();
            bio.Add(bioHumaine);


            //Ajout des professeurs
            Enseignant pafavier = new Enseignant("Favier", "Pierre-Alexandre", "pierre-alexandre.favier@ensc.fr", infoWeb);
            Enseignant bpesquet = new Enseignant("Pesquet", "Baptiste", "bpesquet@ensc.fr", infoWeb);
            Enseignant eclermont = new Enseignant("Clermont", "Edwige", "eclermont@ensc.fr", infoWeb);
            Enseignant csemal = new Enseignant("Semal", "Catherine", "csemal@ensc.fr", projets1A);
            Enseignant ekij = new Enseignant("Kij", "Elisabeth", "ekij@ensc.fr", projets1A);
            Enseignant saries = new Enseignant("Ariès", "Serge", "saries@ensc.fr", GCCo);
            Enseignant bprebot = new Enseignant("Prebot", "Baptiste", "bprebot@ensc.fr", infoWeb);
            Enseignant aroc = new Enseignant("Roc", "Aline", "aroc@ensc.fr", infoWeb);
            Enseignant larsac = new Enseignant("Arsac", "Laurent", "larsec@ensc.fr", bio);
            List<Enseignant> listProfs = new List<Enseignant>();
            listProfs.Add(pafavier); listProfs.Add(bpesquet); listProfs.Add(eclermont); listProfs.Add(csemal); listProfs.Add(ekij);
            listProfs.Add(saries); listProfs.Add(bprebot); listProfs.Add(aroc); listProfs.Add(larsac);

            //Ajout des intervenants extérieurs
            Exterieur rgay = new Exterieur("Gay", "Roland", "roland.gay@gmail.com", "AVEUGLE");


            //Ajout des élèves
            Eleve eguerin = new Eleve("Guerin", "Elisa", "elisa@ensc.fr", 2022);
            Eleve ethomas = new Eleve("Thomas", "Enora", "enthomas@encs.fr", 2022);
            Eleve cdurand = new Eleve("Durand", "Caroline", "cdurand@encs.fr", 2022);
            Eleve tmaneux = new Eleve("Maneux", "Tangi", "tmaneux@encs.fr", 2022);
            Eleve lcalice = new Eleve("Calice", "Laetitia", "claetitia@encs.fr", 2021);
            Eleve mandrian = new Eleve("Andriantsoamberomanga", "Maeva", "maevaandria@encs.fr", 2021);
            Eleve lbregier = new Eleve("Bregier", "Lisa", "lbregier@encs.fr", 2021);
            Eleve mcarliez = new Eleve("Carliez", "Marine", "mcarliez@encs.fr", 2022);
            Eleve cdupetit = new Eleve("Dupetit", "Camille", "cdupetit@encs.fr", 2022);
            Eleve cvalentin = new Eleve("Valentin", "Clara", "cvalentin@encs.fr", 2022);
            Eleve mlucas = new Eleve("Lucas", "Mael", "mlucas@encs.fr", 2022);
            Eleve mndiaye = new Eleve("Ndiaye", "Mariam", "mndiaye@encs.fr", 2022);
            Eleve jpetit = new Eleve("Petit", "Jade", "jpetit@encs.fr", 2022);
            Eleve tligny = new Eleve("De Ligny", "Tiphaine", "tligny@encs.fr", 2022);


            //Projets Transdi
            Sujet sujTransdi1 = new Sujet("Aider les malvoyants à se deplacer en mer", true);
            Transdisciplinaire transd1 = new Transdisciplinaire(rgay, csemal, 2019, new DateTime(2019, 09, 20), sujTransdi1, 6);
            //ajoute le tien si tu veux

            //Projets Transpromo
            Sujet sujTranspromo1 = new Sujet("Créer une application de premiers secours", false);
            Transpromo transp1 = new Transpromo(csemal, csemal, 2019, new DateTime(2019, 09, 10), sujTranspromo1, 6);
            //Faire une boucle pour ça ?
            transp1.AjouterEleve(eguerin);
            transp1.AjouterEleve(mndiaye);
            //ajoute le tien si tu veux

            //Projets IntroProg
            Sujet sujIntroProg = new Sujet("Créer le jeu MOTUS sur console", true);
            IntroProg projIntroProg1 = new IntroProg(2019, new DateTime(2019, 11, 10), sujIntroProg);
            IntroProg projIntroProg2 = new IntroProg(2019, new DateTime(2019, 11, 10), sujIntroProg);
            IntroProg projIntroProg3 = new IntroProg(2019, new DateTime(2019, 11, 10), sujIntroProg);

            //Projet de fin d'études

            AjouterProjet(transd1);
            AjouterProjet(transp1);
            AjouterProjet(projIntroProg1);
            AjouterProjet(projIntroProg2);
            AjouterProjet(projIntroProg3);
            
        }


    }
}