using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Számológép
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Számológép");
            while (true)
            {
                int szam1 = 0;
                int szam2 = 0;
                Console.Write("Milyen műveletet szeretne elvégezni : +;-;*;/;:");
                string muvelet = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(muvelet))
                {
                    break;
                }
                Console.WriteLine("Adja meg az első számot:");
                szam1 = int.Parse(Console.ReadLine());
                while (szam1==0)
                {
                    Console.WriteLine("Adja meg az első számot:");
                    szam1 = int.Parse(Console.ReadLine());
                }
                while (szam2 == 0)
                {
                        Console.WriteLine("Adja meg a második számot:");
                        szam2 = int.Parse(Console.ReadLine());
                }

                if (muvelet=="+")
                {
                    Console.WriteLine($"{szam1} + {szam2} = {szam1+szam2}");
                }
                else if (muvelet == "-")
                {
                    Console.WriteLine($"{szam1} - {szam2} = {szam1 - szam2}");
                }
                else if (muvelet == "*")
                {
                    Console.WriteLine($"{szam1} * {szam2} = {szam1 * szam2}");
                }
                else if (muvelet == "/")
                {
                    Console.WriteLine($"{szam1} / {szam2} = {szam1 / szam2} a maradék {szam1 % szam2}");
                }
            }
            
            Console.ReadKey();
        }
    }
}
