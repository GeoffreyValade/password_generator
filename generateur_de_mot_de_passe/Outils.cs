using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class Outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }

        public static int DemanderNombreEntre(string question, int min, int max)
        {
            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            Console.WriteLine("Erreur : le nombre doit être compris entre " + min + " et " + max);

            return DemanderNombreEntre(question, min, max);
        }

        public static int DemanderNombre(string question)
        {

            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();

                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez rentrer un nombre.");

                }

            }

        }


    }
}
