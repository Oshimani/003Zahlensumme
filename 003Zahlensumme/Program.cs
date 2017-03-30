using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Zahlensumme
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            int startZahl =Convert.ToInt16(Console.ReadLine());
            int stopZahl = Convert.ToInt16(Console.ReadLine());

            while (startZahl <= stopZahl)
            {
                summe = summe + startZahl;
                startZahl = startZahl + 1;
            }
            Console.WriteLine("Summe: {0}", summe);
        }
    }
}
