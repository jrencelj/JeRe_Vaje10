using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NALOGA 1
            int[] tabelaStevil = new int[] { 2, 4, 7, 9, 10, 11, 13, 14, 17, 19, 20, 21, 25, 35, 49 };
            // A) izpiši vsoto števil iz tabele tabelaStevil, ki pri deljenju s 4 dajo ostanek 0 ali 2. 
            // Poizvedbo zapiši v obliki METODE.
            int stevilaEna = tabelaStevil.Where(x => x % 4 == 0 || x % 4 == 2).Sum();
            // B) izpiši števila iz tabele tabelaStevil, ki pri deljuenju z številom 7 dajo ostanek 0, 3 ali 5.
            // Poizvedbo zapiši v obliki POIZVEDBE.
            var stevilaDva = from stevilo in tabelaStevil where stevilo % 7 == 0 || stevilo % 7 == 3 || stevilo % 7 == 5 select stevilo;


            // NALOGA 2

            string[] tabelaNizov = new string[] { "Ana", "Lea", "Pia", "Miha", "Polona", "Nina", "Aleksandra", "Matija", "Larisa", "Marinka", "Laura" };

            // A) Nize v tabeli tabelaNizov izpiši kot en skupen niz, ki ima elemente tabele ločene z znakom "-".
            // Poizvedbo zapiši v obliki METODE.

            string niz = tabelaNizov.Aggregate((prvaBeseda, drugaBeseda) => prvaBeseda + "-" + drugaBeseda);

            // B) Izpiši besede v tabeli tabelaNizov, ki vsebujejo natanko dva a-ja (ne razlikujemo med velikimi in malimi črkami)
            // Uredi jih po prvi črki besede in nato po dolžini od najdaljše do najkrajše.
            // Poizvedbo zapiši v obliki METODE.

            var besede = tabelaNizov.Where(beseda => (beseda.Count(b => b == 'a' || b == 'A')) == 2).OrderBy(b => b.Length);

            Console.WriteLine(stevilaEna);
            foreach (int stevilo in stevilaDva)
            {
                Console.WriteLine(stevilo);
            }
            Console.WriteLine(niz);
            foreach (string beseda in besede)
            {
                Console.WriteLine(beseda);
            }
            Console.ReadKey();
        }
    }
}