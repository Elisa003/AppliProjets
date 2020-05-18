using System;
using System.Collections.Generic;
using System.Net.Http;

namespace AppliProjets
{
    class Program
    {
        static void Main(string[] args)
        {
            Exterieur gay = new Exterieur("Gay", "Roland", "roland.gay@gmail.com", "AVEUGLE");
            
            List<Matiere> matrs = new List<Matiere>();
            matrs.Add(new Matiere("C0005INFO", "Informatique" ));

            Enseignant paf = new Enseignant("Favier", "Pierre-Alexandre", "paf@ensc.fr", matrs);

            Eleve moi = new Eleve("Guerin", "Elisa", "elisa@ensc.fr", 2022);

            Sujet suj = new Sujet("Faire nager les aveugles", false);

            Transpromo transp = new Transpromo(gay, paf, 2019, new DateTime(2019, 9, 12), suj, 6);
            transp.AjouterEleve(moi);
        }
    }
}
