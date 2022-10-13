using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    /* titre : Denombrements
     * description : effectue des opération de permutations arrangements et combinaisons
     * auteur : johannes massiani
     * date création : 13/10/2022
     * date dernière modification : 13/10/2022
     */
    class Program
    {
        /// <summary>
        /// fonction pour la saisie du nombre d'éléments
        /// </summary>
        /// <param name="message">message de saisie</param>
        /// <returns></returns>
        static int elements(string message)
        {
            // le nombre d'éléments à gérer
            Console.Write(message);
            int reponse = int.Parse(Console.ReadLine());
            return reponse;
        }
        /// <summary>
        /// Focntion du calcul répété
        /// </summary>
        /// <param name="nr"></param>
        /// <returns></returns>
        static long calculr(int nr)
        {
            int retour = 1;
            for (int k = 1; k <= nr; k++)
            {
                retour *= k;
            }
            return retour;
        }

        /// <summary>
        /// programme principal, affiche le menu et les opérations
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            int coucou = 1;
            while (coucou != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                coucou = int.Parse(Console.ReadLine());

                if (coucou == 0) { Environment.Exit(0); }

                if (coucou == 1)
                {
                    int n = elements("nombre total d'éléments à gérer = ");
                    // calcul de r
                    long r = calculr(n);
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (coucou == 2)
                    {
                        int tare = elements("nombre total d'éléments à gérer = ");
                        int n = elements("nombre d'éléments dans le sous ensemble = ");
                        // calcul de r
                        long r = 1;
                        for (int k = (tare - n + 1); k <= tare; k++)
                            r *= k;
                        Console.WriteLine("A(" + tare + "/" + n + ") = " + r);
                    }
                    else
                    {
                        if (coucou == 3)
                        {
                            int tare = elements("nombre total d'éléments à gérer = ");
                            int n = elements("nombre d'éléments dans le sous ensemble = ");
                            // calcul de r1
                            long r1 = 1;
                            for (int k = (tare - n + 1); k <= tare; k++)
                                r1 *= k;
                            // calcul de r2
                            long r2 = calculr(n);
                            // calcul de r3
                            Console.WriteLine("C(" + tare + "/" + n + ") = " + (r1 / r2));
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
