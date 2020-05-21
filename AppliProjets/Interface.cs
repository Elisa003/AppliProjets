using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppliProjets
{
    class Interface
    {
        public static void LancerInterface()
        {
            bool lancer = true;
            while (lancer)
            {
                Catalogue catalogue = new Catalogue(4);
                Projet[] projets = catalogue.Liste();


                Catalogue.ApproCatalogue();

                Console.WriteLine("BIENVENUE SUR L'ANNUAIRE DES PROJETS DE L'ENSC !\n");
                bool actif = true;

                while (actif && lancer)
                {
                    Console.WriteLine("Que souhaitez vous faire ?");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Consulter tous les projets.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  (Ecrire : consulter)\n");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Faire une recherche");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  (Ecrire : rechercher)\n");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Ajouter un projet");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  (Ecrire : ajouter)\n");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Quitter");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  (Ecrire : quitter)\n\n");
                    string action = Console.ReadLine();

                    if (action == "consulter")
                    {
                        Console.WriteLine("\n=== Voici la liste de tous les projets de l'ENSC ===\n");
                        for (int i = 0; i < projets.Length; i++)
                        { Console.WriteLine(projets[i].ToString()); }
                        Console.WriteLine("\n");
                    }
                    else if (action == "rechercher")
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Quel mot clé voulez vous rechercher ?"); //motclé ou intervenant etc
                        string motCle = Console.ReadLine();
                        Console.WriteLine("=== Voici tous les projets qui contiennent le mot clé {0} ===", motCle);
                        projets[0].RecherchePar(motCle);
                        Console.WriteLine("\n");
                    }
                    else if (action == "ajouter")
                    {
                        Console.WriteLine("En quelle année s'est déroulé ce projet ?");
                        int anneeScolaire = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quelle est la date de début du projet ?");
                        DateTime dateDebut = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Quel  est l'intitulé du sujet ?");
                        string intitule = Console.ReadLine();
                        Console.WriteLine("Le sujet est-il imposé ? (oui : true, non : false");
                        bool impose = bool.Parse(Console.ReadLine());
                        Sujet sujet = new Sujet(intitule, impose);
                        Console.WriteLine("Quel est le type de projet ?\n(Introduction à la programmation : prog\nProjet de fin d'études : pfe\nTransdisciplinaire : transdi\nTranspromotion : transpromo)");
                        string type = Console.ReadLine();
                        string nom;
                        string prenom;
                        string mail;
                        string orga;
                        if (type == "prog")
                        {
                            IntroProg intrProg = new IntroProg(anneeScolaire, dateDebut, sujet);
                            Catalogue.AjouterProjet(intrProg);
                        }
                        else if (type == "pfe")
                        {
                            Console.WriteLine("Qui est le tuteur ?\n(une personne extérieur : exte, un enseignant : prof)");
                            string inter = Console.ReadLine();
                            if (inter == "exte")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();
                                Console.WriteLine("Quelle est son organisation/son entreprise ?");
                                orga = Console.ReadLine();
                                Exterieur tuteur = new Exterieur(nom, prenom, mail, orga);
                                ProjetFinEtudes projetFE = new ProjetFinEtudes(tuteur, anneeScolaire, dateDebut, sujet);
                                Catalogue.AjouterProjet(projetFE);
                            }
                            else if (inter == "prof")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();

                                Enseignant tuteur = new Enseignant(nom, prenom, mail);
                            }
                            else
                            {
                                lancer = false;
                            }
                        }
                        else if (type == "transdi")
                        {
                            Console.WriteLine("Combien d'étudiants travaillent sur ce projet ?");
                            int nbEtudiants = int.Parse(Console.ReadLine());
                            Console.WriteLine("Qui est le tuteur ?\n(une personne extérieur : exte, un enseignant : prof)");
                            string inter1 = Console.ReadLine();
                            
                            if (inter1 == "exte")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();
                                Console.WriteLine("Quelle est son organisation/son entreprise ?");
                                orga = Console.ReadLine();
                                Exterieur tut = new Exterieur(nom, prenom, mail, orga);
                            }
                            else if (inter1 == "prof")
                            {
                                //On va faire comme si il fallait le créer
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();

                                Enseignant tut = new Enseignant(nom, prenom, mail);
                            }
                            else
                            {
                                lancer = false;
                            }
                            
                            Console.WriteLine("Qui est le client ?\n(une personne extérieur : exte, un enseignant : prof)");
                            string inter2 = Console.ReadLine();
                            if (inter2 == "exte")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();
                                Console.WriteLine("Quelle est son organisation/son entreprise ?");
                                orga = Console.ReadLine();
                                Exterieur client = new Exterieur(nom, prenom, mail, orga);
                            }
                            else if (inter2 == "prof")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();
                                
                                Enseignant client = new Enseignant(nom, prenom, mail);
                            }
                            else
                            {
                                lancer = false;
                            }
                            
                            Transdisciplinaire transD = new Transdisciplinaire(client, tuteur, anneeScolaire, dateDebut, sujet, nbEtudiants);
                        }
                        else if (type == "transpromo")
                        {
                            Console.WriteLine("Combien d'étudiants travaillent sur ce projet ?");
                            int nbEtudiants = int.Parse(Console.ReadLine());
                            Console.WriteLine("Qui est le tuteur ?\n(une personne extérieur : exte, un enseignant : prof)");
                            string inter1 = Console.ReadLine();
                            if (inter1 == "exte")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();
                                Console.WriteLine("Quelle est son organisation/son entreprise ?");
                                orga = Console.ReadLine();
                                Exterieur tuteur = new Exterieur(nom, prenom, mail, orga);
                            }
                            else if (inter1 == "prof")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();

                                Enseignant tuteur = new Enseignant(nom, prenom, mail);
                            }
                            else
                            {
                                lancer = false;
                            }
                            
                            Console.WriteLine("Qui est le client ?\n(une personne extérieur : exte, un enseignant : prof)");
                            string inter2 = Console.ReadLine();
                            if (inter2 == "exte")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();

                            }
                            else if (inter2 == "prof")
                            {
                                Console.WriteLine("Quel est son nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Quel est son prénom ?");
                                prenom = Console.ReadLine();
                                Console.WriteLine("Quel est son adresse mail ?");
                                mail = Console.ReadLine();

                            }
                            else
                            {
                                lancer = false;
                            }
                            //Intervenant client = new Intervenant(nom, prenom, mail);
                            Transpromo transpromo = new Transpromo(client, tuteur, anneeScolaire, dateDebut, sujet, nbEtudiants);
                        }
                        else
                        {
                            lancer = false;
                        }
                        Console.WriteLine("\n");
                    }
                    else if (action == "quitter")
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("--------- A la prochaine ! ---------");
                        lancer = false;
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Désolé je n'ai pas compris.");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
