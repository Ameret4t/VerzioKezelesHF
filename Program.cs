using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            beker();
            Console.ReadKey();
        }

        public static void beker() {
            Console.WriteLine("Kérem adja meg az elemszámot!");
            int darabszam = int.Parse(Console.ReadLine());
            int[] bekert = new int[darabszam];
            for (int i = 0; i <  bekert.Length; i++)
            {
                bekert[i] = int.Parse(Console.ReadLine());
            }
            int atlag = 0;
            for (int i = 0; i < bekert.Length; i++)
            {
                atlag = atlag + bekert[i];
            }
            atlag = atlag / darabszam;

        }
    }
}
