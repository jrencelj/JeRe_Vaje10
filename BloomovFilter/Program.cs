using BloomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloomovfilter
{
    internal class Program
    {
        private static IBloomFilter bloomovFilter = FilterBuilder.Build(25, 0.1);
        static void Main(string[] args)
        {
            string abeceda = "abcčdefghijklmnoprsštuvzž";
            foreach (char crka in abeceda)
            {
                bloomovFilter.Add(crka);
            }
            Console.WriteLine(bloomovFilter.Contains(' '));
            Console.ReadKey();
        }
    }
}