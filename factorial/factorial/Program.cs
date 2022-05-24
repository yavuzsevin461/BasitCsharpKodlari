using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degerstr=String.Empty;
            int degerint = 0;
            int faktoriyel = 1;

            Console.Write("Hangi sayının faktoriyeli alınsın? ");
            degerstr=Console.ReadLine();
            degerint = Convert.ToInt32(degerstr);
            if (degerint < 0)
            {
                Console.WriteLine("negatif sayı girilemez");
            }
            else
            {
                for (int i = 1; i <= degerint; i++)
                {
                    faktoriyel *= i;
                }
                Console.WriteLine(degerstr + " nin faktoriyeli " + faktoriyel + "dir");
            }


            Console.ReadLine();
        }
    }
}
