using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            pocetak:
            Console.Clear();
            Console.Write("Unesi jedan broj: ");
            double broj1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("odabetire operater: ");
            string operater = Console.ReadLine();
            Console.Write("Unesi drugi broj: ");
            double broj2 = Convert.ToDouble(Console.ReadLine());

            if (operater == "+")
            {
                Console.Clear();
                Console.Write(broj1 + broj2);
                Console.ReadKey();
                goto pocetak;
            }
            else if (operater == "-")
            {
                Console.Clear();
                Console.Write(broj1 - broj2);
                Console.ReadKey();
                goto pocetak;
            }
            else if (operater == "*")
            {
                Console.Clear();
                Console.Write(broj1 * broj2);
                Console.ReadKey();
                goto pocetak;
            }
            else if (operater == "/")
            {
                Console.Clear();
                Console.Write( broj1 / broj2);
                Console.ReadKey();
                goto pocetak;
            }
            else if (operater == "pow")
            {
                Console.Clear();
                Console.Write(Math.Pow(broj1, broj2));
                Console.ReadKey();
                goto pocetak;
            }
            else if (operater == "sqrt")
            {
                Console.Clear();
                Console.Write(Math.Sqrt(broj1));
                Console.ReadKey();
                goto pocetak;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Niste unjeli podrzani matematicki operater");
                Console.ReadKey();
                goto pocetak;
            }
        }
    }
}
