using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Balkezesek
{
    class Program
    {
        static List<Versenyzok> adatok = new List<Versenyzok>();

        static void MasodikFeladat()
        {
            StreamReader file = new StreamReader("balkezesek.csv");

            file.ReadLine();

            while (!file.EndOfStream)
            {
                string[] adat = file.ReadLine().Split(';');
                adatok.Add(new Versenyzok(adat[0], adat[1], adat[2], int.Parse(adat[3]), int.Parse(adat[4])));
            }
            file.Close();
        }
        static void HarmadikFeladat()
        {
            int sorok = 0;
            foreach (var a in adatok)
            {
                sorok++;
            }
            Console.WriteLine("3. feladat : {0}", sorok);
        }
        static void NegyedikFeladat()
        {
            
        }

        static void Main(string[] args)
        {
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            Console.ReadKey();
        }
    }
}
