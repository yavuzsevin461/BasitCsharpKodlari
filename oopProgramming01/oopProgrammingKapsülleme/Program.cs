using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProgrammingKapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.isim = "Yavuz";
            M1.soyisim = "Sevin";
            M1.Email = "yavuzsevin1661@gmail.com";
            Console.Write(M1.Email);
            Console.WriteLine("Musteri id değeri= " + M1.Id.ToString());
        }
    }
}
