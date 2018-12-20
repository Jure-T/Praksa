using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversestringigra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::::Igra Riječi:::::");
            Console.Write("unesi svoje ime: ");
            string ime = Console.ReadLine();
            Console.Write("unesi svoje prezime: ");
            string prezime = Console.ReadLine();
            Console.Write("unesi grad u kojem živiš: ");
            string grad = Console.ReadLine();

            Rezultat(ObrnutiString(ime), ObrnutiString(prezime), ObrnutiString(grad));
            Console.ReadLine();
        }
        private static string ObrnutiString(string odgovor)
        {
            Char[] odgovorArray = odgovor.ToCharArray();
            Array.Reverse(odgovorArray);
            return String.Concat(odgovorArray);
        }
        private static void Rezultat(string Obrnutoime, string Obrnutoprezime, string Obrnutigrad)
        {
            Console.Write("Rezultat: ");
            Console.Write(string.Format("{0} {1} {2}", Obrnutoime, Obrnutoprezime, Obrnutigrad));
        }
        private static void Rezultat(string Odgovor)
        {
            Console.Write("Rezultat: ");
            Console.Write(Odgovor);
        }
    }
}
