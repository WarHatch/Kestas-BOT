using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineAndVirusGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
#region Intro
            Console.WriteLine("---------------------------------");
            Console.WriteLine("------ K e s t a s - B O T ------");
            Console.WriteLine("---------------------------------\n");
#endregion
            start:
            Console.WriteLine("> Iveskite sugeneruotu irasu kieki");
            int irasuKiekis = int.Parse(Console.ReadLine());

            Console.WriteLine("> Iveskite failo pavadinima (su formatu). Pvz: data.txt");
            string failoPavadinimas = Console.ReadLine();

            /* not yet implemented
            Console.WriteLine("> Ar reikia issaugoti irasu skaiciu ir irasyti failo pradzioje. Iveskite 't' jei taip");
            string kiekioIssaugojimas_string = Console.ReadLine();
            bool kiekioIssaugojimas = (kiekioIssaugojimas_string == "t") ? true : false;
            */

            FileGenerator generatorius = new FileGenerator(failoPavadinimas);

            tipoPasirinkimas:
            Console.WriteLine("> Pasirinkite duomenu tipa");
            Console.WriteLine("> 1) Binary");
            Console.WriteLine("> 2) Numbers (integers) (a.k.a. Barbora's generation)");
            Console.WriteLine("> 69) The K E S T A S special");

            int pasirinkimas = int.Parse(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("> Iveskite eilutes ilgi (t.y. kiek bool bus eilutej)");
                    int ilgis_binary = int.Parse(Console.ReadLine());
                    generatorius.BinaryGenerate(irasuKiekis, ilgis_binary);
                    break;
                case 2:
                    Console.WriteLine("> Iveskite eilutes ilgi (t.y. kiek bool bus eilutej)");
                    int ilgis_int = int.Parse(Console.ReadLine());
                    Console.WriteLine("> Iveskite max skaiciu (inclusive)");
                    int maxSkaicius = int.Parse(Console.ReadLine());
                    generatorius.IntegerGenerate(irasuKiekis, ilgis_int, maxSkaicius);
                    break;
                case 69:
                    generatorius.KestasGenerate(irasuKiekis);
                    break;
                default:
                    Console.WriteLine("> Klaida: Neteisingas pasirinkimas. Bandykite dar karta");
                    goto tipoPasirinkimas;
            }

            Console.WriteLine("> Failas sugeneruotas sekmingai!");
            Console.WriteLine("> Kartoti? Iveskite 't'");
            string kartoti = Console.ReadLine();
            if (kartoti == "t")
                goto start;
        }
    }
}
