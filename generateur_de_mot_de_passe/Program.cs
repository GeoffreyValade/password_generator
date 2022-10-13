using System;
using FormationCS;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[]   args)
        {

            const int NB_MOTS_DE_PASSE = 10;

            // Demander la longueur du mot de passe      int longueur_mdp = . . . 
            int longueurMdp = Outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            // La désignation << Outils. >> vient du compartiment du même nom, à droite. Les fonctions sont intégrées pour être réutilisées.

            // Choix de l'alphabet :
            int choixAlphabet = Outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
                             "1 - Uniquement des caractères en minuscule\n" +
                             "2 - Des caractères minuscules et majuscules\n" +
                             "3 - Des caractères minuscules, majuscules et des chiffres\n" +
                             "4 - Des caractères minuscules, majuscules, des chiffres et spéciaux\n" +
                             "Votre choix : ", 1, 4);

            // On détermine tous nos alphabets via des strings.
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "&+=-#_():;";
            string alphabet;
            string motDePasse = "";

            Random rand = new Random();

            // On fait la liaison entre le choix de l'utilisateur et les alphabets que nous avons déterminés au dessus.
            if (choixAlphabet == 1)
                alphabet = minuscules;
            else if (choixAlphabet == 2)
                alphabet = minuscules + majuscules;
            else if (choixAlphabet == 3)
                alphabet = minuscules + majuscules + chiffres;
            else
                alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;
            
            int longueurAlphabet = alphabet.Length;


            // Génération de mots de passe via des boucles :

            for (int j = 0; j < NB_MOTS_DE_PASSE; j++) // Cette boucle pour générer plusieurs mots de passe s'imbrique au dessus de l'autre
            {
                motDePasse = "";
                // la ligne << motDePasse = ""; >> est indispensable ici. Sinon, le mot de passe donné par le programme ne sera pas clear.
                // Au pire, test. Enlève juste la ligne << motDePasse = ""; >>. Tu verras bien ce que ça fait.

                for (int i = 0; i < longueurMdp; i++) // Cette boucle génère les mots de passe de façon aléatoire en piochant via un rand dans les alphabets.
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];
                }

                Console.WriteLine("Mot de passe : " + motDePasse);
                // On met le Writeline ici, car la mettre au dessus signifierait que le programme va afficher toutes les lettres choisies une par une.
                // Au pire test. Coupe/Colle la ligne Writeline et mets-la dans la boucle for (i), tu verras le résultat.

            }

        }


    }


}