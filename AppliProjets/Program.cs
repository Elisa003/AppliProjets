using System;
using System.Collections.Generic;
using System.Net.Http;

namespace AppliProjets
{
    class Program
    {
        static void Main(string[] args)
        {


            ////////////////////
            Interface.LancerInterface();

            Environment.Exit(0);
            /*Catalogue catalogue = new Catalogue(4);

            Exterieur gay = new Exterieur("Gay", "Roland", "roland.gay@gmail.com", "AVEUGLE");

            List<Matiere> matrs = new List<Matiere>();
            Matiere info = new Matiere("C0005INFO", "Informatique");
            matrs.Add(info);

            Enseignant paf = new Enseignant("Favier", "Pierre-Alexandre", "paf@ensc.fr", matrs);

            Eleve moi = new Eleve("Guerin", "Elisa", "elisa@ensc.fr", 2022);
            Eleve toi = new Eleve("Thomas", "Enora", "enthomas@encs.fr", 2002);

            CodeSource code = new CodeSource("quizz", "c#");
            Rapport rapp = new Rapport("GUERIN_THOMAS", 15);
            SiteWeb site = new SiteWeb("QUIZZ", "https://quizz.com");
            Soutenance soute = new Soutenance("RAO", 30);
            DateTime date = DateTime.Now;

            Sujet suj = new Sujet("Faire nager les aveugles", false);

            Transpromo transp = new Transpromo(gay, paf, 2019, new DateTime(2019, 9, 12), suj, 6);
            transp.AjouterEleve(moi);
            transp.AjouterEleve(toi);

            IntroProg prog = new IntroProg(2020, date, suj);
            prog.AjouterEleve(moi);
            prog.AjouterEleve(toi);
            ProjetFinEtudes pfe = new ProjetFinEtudes(paf, 2021, date, suj);
            pfe.AjouterEleve(moi);
            pfe.AjouterLivrable(site);
            Transdisciplinaire transdi = new Transdisciplinaire(gay, paf, 2022, date, suj, 6);
            transdi.AjouterEleve(moi);
            transdi.AjouterEleve(toi);
            transdi.AjouterLivrable(code);

            transp.SupprFichier("SauvProjets.txt");
            Console.WriteLine(catalogue.AjouterProjet(transp));
            Console.WriteLine(catalogue.AjouterProjet(prog));
            Console.WriteLine(catalogue.AjouterProjet(pfe));
            Console.WriteLine(catalogue.AjouterProjet(transdi));

            Projet[] projets = catalogue.Liste();



    */


        }
    }
}
