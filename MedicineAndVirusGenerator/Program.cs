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
            Console.WriteLine("> Iveskite sugeneruotu irasu kieki");
            int irasuKiekis = int.Parse(Console.ReadLine());

            tipoPasirinkimas:
            Console.WriteLine("> Pasirinkite duomenu tipa");
            Console.WriteLine("> 1) Binary");
            Console.WriteLine("> 2) Numbers (integers)");
            Console.WriteLine("> 69) The K E S T A S special");

            int pasirinkimas = int.Parse(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 69:
                    FileGenerator virusuGeneratorius = new FileGenerator("Virusai.");
                    virusuGeneratorius.GenerateFile(8);
                    FileGenerator vaistuGeneratorius = new FileGenerator("Vaistai.");
                    vaistuGeneratorius.GenerateFile(4);
                    break;
                default:
                    Console.WriteLine("> Klaida: Neteisingas pasirinkimas. Bandykite dar karta");
                    goto tipoPasirinkimas;
            }

            //TODO:
            //Console.WriteLine(">Iveskite max skaiciaus verte");
            //int irasuKiekis = int.Parse(Console.ReadLine());
        }
    }
}
