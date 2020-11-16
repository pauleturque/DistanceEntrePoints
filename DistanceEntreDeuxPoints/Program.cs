using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEntreDeuxPoints
{
    class Program
    {
        static void distance(int val1, int val2, ref int result)
        {
            if(val1 > val2)
            {
                result = val1 - val2;
            }
            else
            {
                result = val2 - val1;
            }
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("Entrez la distance du point A :");
            int saisie1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la distance du point B :");
            int saisie2 = int.Parse(Console.ReadLine());

            // calcul de la distance
            int distce = 0;
            distance(saisie1, saisie2, ref distce);

            // affichage de la distance
            Console.WriteLine("La distance entre " + saisie1 + " et " + saisie2 + " est de " + distce);
            Console.ReadLine();




        }
    }
}
