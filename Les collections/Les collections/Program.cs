using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Les_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation de la liste du mois
            ArrayList mois = new ArrayList();
            mois.Add("janvier");
            mois.Add("Feb");
            mois.Add("mars");
            mois.Add("avrl");
            mois.Add("mai");
            mois.Add("juin");
            mois.Add("juillet");
            mois.Add("aout");
            mois.Add("sept");
            mois.Add("oct");
            mois.Add("nov");
            mois.Add("dec");
            Console.WriteLine("la valeur de la troisième ligne de cette liste est " + mois[3]);
            Console.WriteLine("la valeur de l'index 5 est" + mois[5]);
            ;

            Console.WriteLine("Question 4");
            foreach(object M in mois)
            {
                Console.WriteLine(M);
            }
            mois[7] = "août";
            Console.WriteLine("Question 5");
            foreach (object M in mois)
            { 
                Console.WriteLine (M);
            }

            mois.Insert(0, "Element");
            Console.WriteLine("Question 6");
            foreach (object M in mois)
            {
                Console.WriteLine(M);
            }
            mois.RemoveAt(3);
            foreach (object M in mois)
            {
                Console.WriteLine(M);
            }
            Console.WriteLine(mois.Contains("janvier"));
            mois.Sort();
            foreach (object M in mois)
            {
                Console.WriteLine(M);
            }
            ArrayList B = new ArrayList();
            B.AddRange(mois);
            Console.WriteLine(B);
           
        }
    }
}
