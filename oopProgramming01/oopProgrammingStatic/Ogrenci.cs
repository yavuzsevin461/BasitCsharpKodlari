using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProgrammingStatic
{
    internal class Ogrenci
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public String EmailAdres { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metot");
            Test2();// static bir metod statik olmayan bir metod içinden çağrılabilir lakin tersi münkün değildir.
        }
        
        public static void Test2()
        {
            Console.WriteLine("Nesne örneği alınmadan kullanılabilir.");
        }
    }
}
