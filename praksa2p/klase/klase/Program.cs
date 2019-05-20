using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase
{
    class Program
    {
        static void Main(string[] args)
        {
            knjiga knjiga1 = new knjiga();

            knjiga1.ime = "Harry Potter";
            knjiga1.autor = "JK Rowling";
            knjiga1.brojStranica = 500;
            knjiga1.sadrzaj = "Tekst knjige....";

            knjiga knjiga2 = new knjiga();

            knjiga2.ime = "snjeguljica";
            knjiga2.autor = "Planetopija";
            knjiga2.brojStranica = 24;
            knjiga2.sadrzaj = "Tekst knjige....";

            string unos = "";
            pocetak:
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Odabetire knjigu: 1.Harry Potter");
            Console.WriteLine("                  2.Snjeguljica");
            Console.WriteLine("--------------------------------");
            unos = Console.ReadLine();
            if (unos == "1" || unos== "Harry Potter")
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Naslov: " + knjiga1.ime);
                Console.WriteLine("Autor knjige: " + knjiga1.autor);
                Console.WriteLine("Broj Stranica: " + knjiga1.brojStranica);
                Console.WriteLine("|" + knjiga1.sadrzaj + "|");
                Console.WriteLine("--------------------------------");
            }
            else if (unos == "2" || unos == "Snjeguljica")
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Naslov" + knjiga2.ime);
                Console.WriteLine("Autor knjige: " + knjiga2.autor);
                Console.WriteLine("Broj Stranica: " + knjiga2.brojStranica);
                Console.WriteLine("|" + knjiga2.sadrzaj + "|");
                Console.WriteLine("--------------------------------");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Niste unjeli dostupnu knjigu");
                Console.WriteLine("--------------------------------");
            }
            Console.ReadKey();
            goto pocetak;
        }
    }
}
