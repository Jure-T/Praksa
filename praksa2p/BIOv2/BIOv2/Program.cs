using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIOv2
{
    class Program
    {
        static void Main(string[] args)
        {
        pocetak:
            Console.Clear();
            Console.WriteLine("-----------");
            Console.WriteLine("xxx86006165");
            Console.WriteLine("xxx12345678");
            Console.WriteLine("xxx23456789");
            Console.WriteLine("-----------");
            Console.Write("Unesite OIB: ");
            string OIB = Console.ReadLine();
            if (OIB == "xxx86006165")
            {
                Console.Clear();
                Console.WriteLine("Podatci:");
                Console.WriteLine("Ime:                     Jure");
                Console.WriteLine("Prezime:                 Tomsic");
                Console.WriteLine("Datum rođenja:           30.1.2001");
                Console.WriteLine("Mjesto rođenja:          Osijek");
                Console.WriteLine("adresa:                  Jovana Gojkovica 19 31000 Osijek");
                Console.ReadKey();
            }
            else if (OIB == "xxx12345678")
            {
                Console.Clear();
                Console.WriteLine("Podatci:");
                Console.WriteLine("Ime:                     Pajo");
                Console.WriteLine("Prezime:                 Patak");
                Console.WriteLine("Datum rođenja:           4.5.2002");
                Console.WriteLine("Mjesto rođenja:          Zagreb");
                Console.WriteLine("adresa:                  Ulica 23 10000 Zagreb");
                Console.ReadKey();
            }
            else if (OIB == "xxx23456789")
            {
                Console.Clear();
                Console.WriteLine("Podatci:");
                Console.WriteLine("Ime:                     Mare");
                Console.WriteLine("Prezime:                 Adams");
                Console.WriteLine("Datum rođenja:           18.3.2003");
                Console.WriteLine("Mjesto rođenja:          Zadar");
                Console.WriteLine("adresa:                  Ulica 23 20000 Dubrovnik");
                Console.ReadKey();
            }
            else
	        {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Unjeli ste ne postjeci OIB");
                Console.WriteLine("--------------------------");
                Console.ReadKey();
            goto pocetak;
            }

        }
    }
}
