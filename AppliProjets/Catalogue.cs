using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AppliProjets
{
    public class Catalogue 
    {
        Projet[] projets;
        public Catalogue(int nbProjets)
        {
            projets = new Projet[nbProjets];
        }
        public int NombreProjets { get { return projets.Length; } }
        
        public Projet this [Promo promo]
        {
            get {
                foreach (Projet p in projets)
                    if (p.promo == promo)
                        return p;
                return null;
            }
        }


        //Ajout des matières
        static Matiere introProg = new Matiere("CO5SFIN0", "Introduction à la programmation");
        static Matiere infoComBBWeb = new Matiere("CO5SFBD0", "Information et communication, bases de données et programmation web");
        static Matiere transdi = new Matiere("CO5PRTD0", "Projets transdisciplinaires de l'ENSC");
        static Matiere bioHumaine = new Matiere("CO5SCBIO", "Bases biologie humaine");
        static Matiere gesP = new Matiere("CO6INGP0", "Gestion de projet et conception");
        static Matiere gcco = new Matiere("CO6SCCC0", "Gestion des connaissances et des compétences");
        static Matiere progAv = new Matiere("CO6SFPA0", "Programmation avancée");
        static Matiere commWeb = new Matiere("CO6SFCX0", "Communication web");


        static List<Matiere> infoWeb = new List<Matiere>(); //il faut que ce soir static sinon je peux pas l'ajouter à un prof
        //infoWeb.Add(introProg); //bon bah ça marche pas :'(
        //je crois que c'est parce qu'on est pas dans le Main ... 
        static List<Matiere> projets1A = new List<Matiere>();
        static List<Matiere> GCCo = new List<Matiere>();
        static List<Matiere> bio = new List<Matiere>();


        //Ajout des professeurs
        static Enseignant pafavier = new Enseignant("Favier", "Pierre-Alexandre", "pierre-alexandre.favier@ensc.fr", infoWeb);
        static Enseignant bpesquet = new Enseignant("Pesquet", "Baptiste", "bpesquet@ensc.fr", infoWeb);
        static Enseignant eclermont = new Enseignant("Clermont", "Edwige", "eclermont@ensc.fr", infoWeb);
        static Enseignant csemal = new Enseignant("Semal", "Catherine", "csemal@ensc.fr", projets1A);
        static Enseignant ekij = new Enseignant("Kij", "Elisabeth", "ekij@ensc.fr", projets1A);
        static Enseignant saries = new Enseignant("Ariès", "Serge", "saries@ensc.fr", GCCo);
        static Enseignant bprebot = new Enseignant("Prebot", "Baptiste", "bprebot@ensc.fr", infoWeb);
        static Enseignant aroc = new Enseignant("Roc", "Aline", "aroc@ensc.fr", infoWeb);
        static Enseignant larsac = new Enseignant("Arsac", "Laurent", "larsec@ensc.fr", bio);


        //Ajout des intervenants extérieurs
        static Exterieur rgay = new Exterieur("Gay", "Roland", "roland.gay@gmail.com", "AVEUGLE");


        //Ajout des élèves
        static Eleve eguerin = new Eleve("Guerin", "Elisa", "elisa@ensc.fr", 2022);
        static Eleve ethomas = new Eleve("Thomas", "Enora", "enthomas@encs.fr", 2022);
        static Eleve cdurand = new Eleve("Durand", "Caroline", "cdurand@encs.fr", 2022);
        static Eleve tmaneux = new Eleve("Maneux", "Tangi", "tmaneux@encs.fr", 2022);
        static Eleve lcalice = new Eleve("Calice", "Laetitia", "claetitia@encs.fr", 2021);
        static Eleve mandrian = new Eleve("Andriantsoamberomanga", "Maeva", "maevaandria@encs.fr", 2021);
        static Eleve lbregier = new Eleve("Bregier", "Lisa", "lbregier@encs.fr", 2021);
        static Eleve mcarliez = new Eleve("Carliez", "Marine", "mcarliez@encs.fr", 2022);
        static Eleve cdupetit = new Eleve("Dupetit", "Camille", "cdupetit@encs.fr", 2022);
        static Eleve cvalentin = new Eleve("Valentin", "Clara", "cvalentin@encs.fr", 2022);
        static Eleve mlucas = new Eleve("Lucas", "Mael", "mlucas@encs.fr", 2022);
        static Eleve mndiaye = new Eleve("Ndiaye", "Mariam", "mndiaye@encs.fr", 2022);
        static Eleve jpetit = new Eleve("Petit", "Jade", "jpetit@encs.fr", 2022);
        static Eleve tligny = new Eleve("De Ligny", "Tiphaine", "tligny@encs.fr", 2022);



        //A faire : créer une méthode d'ajout de projet (peut-être celle qui existe déjà dans la classe projet)
        //qui permettrait d'ajouter automatiquement un projet avec toutes les caractéristiques + les élèves
        // + la sauvegarde 

        //cette méthode contiendrait : le constructeur du projet + ajouterEleve() + sauvegarderProjet()




        //Projets Transdi
        static Sujet sujTransdi1 = new Sujet("Aider les malvoyants à se deplacer en mer", true);
        public Transdisciplinaire transd1 = new Transdisciplinaire(rgay, csemal, 2019, new DateTime(2019, 09, 20), sujTransdi1, 6);
        //ajoute le tien si tu veux

        //Projets Transpromo
        static Sujet sujTranspromo1 = new Sujet("Créer une application de premiers secours", false);
        static Transpromo transp1 = new Transpromo(csemal, csemal, 2019, new DateTime(2019, 09, 10), sujTranspromo1, 6);
        //ajoute le tien si tu veux

        //Projets IntroProg
        static Sujet sujIntroProg = new Sujet("Créer le jeu MOTUS sur console", true);
        static IntroProg projIntroProg1 = new IntroProg(2019, new DateTime(2019, 11, 10), sujIntroProg);
        static IntroProg projIntroProg2 = new IntroProg(2019, new DateTime(2019, 11, 10), sujIntroProg);
        static IntroProg projIntroProg3 = new IntroProg(2019, new DateTime(2019, 11, 10), sujIntroProg);

        //Projet de fin d'études

        


        //Je voulais faire ici la sauvegarde et la recherche des projets mais je peux pas faire ça :
        //transd1.SauvegardeProjet();

        
    }
}