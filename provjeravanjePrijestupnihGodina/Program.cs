using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeravanjePrijestupnihGodina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godina = 1900;


            do {

                if (godina % 4 == 0 && godina % 100 != 0 || godina % 400 == 0)
                {
                    Console.WriteLine(godina);
                }

                godina++;

            }while (godina < 2001);

            Console.ReadKey();
        }
    }
}
