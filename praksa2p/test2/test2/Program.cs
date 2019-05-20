using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraPogadjanja
{
    class Program
    {
        static void Main(string[] args)
        {
            string Tajnarijec = "pajo";
            string pokusaj = "";
            int brojpokusaja = 0;
            while (pokusaj != Tajnarijec)
            {
                Console.Clear();
                Console.Write("Unesi rijec: ");
                pokusaj = Console.ReadLine();
                brojpokusaja++;
            }
            Console.Clear();
            Console.WriteLine("Bravo! uspio si rijec je bila pajo.");
            if (brojpokusaja == 1)
            {
                Console.WriteLine("trebao ti je " + brojpokusaja + " pokusaj");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("trebalo ti je " + brojpokusaja + " pokusaja");
                Console.ReadKey();
            }

        }
    }
}
