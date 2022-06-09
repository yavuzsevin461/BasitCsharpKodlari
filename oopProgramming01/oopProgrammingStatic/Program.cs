using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProgrammingStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static::nesne örneği alınmadan ulaşabildiğimiz metot, field, sınıf

            // stack bölgede pointerımız oluştu.
            Ogrenci O1;
            //stack bölgede pointer oluştuğu zaman static olan yapıcı metot çalıştı ve yine class içinde tanımlı olan static field, metot static dediğimiz böolgede oluşturuldu.
            Ogrenci.Test2();

            O1= new Ogrenci();
            //stack bölgede pointer => kendisini heap bölgede tamamladı.staticolmayan tanımlarını tamamladı.
            O1.Test1(); //nesne örneğini aldıktan sonra Test1 adındaki metoduma ulaşabildim.


        }
    }
}
