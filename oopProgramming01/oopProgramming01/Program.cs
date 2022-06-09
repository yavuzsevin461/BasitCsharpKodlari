using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProgramming01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1= new Musteri();
            M1.TCkimlikNumara ="12345678912";
            M1.isim = "Yavuz";
            M1.soyisim = "Sevin";
            M1.cinsiyet = 71777001;
            Musteri M2 = M1;
            M1.cinsiyet = 71777002; // BU GÜNCELLEME YAPILDIĞINDA HER İKİSİNDE DE CİNSİYET DEĞİŞİR. Referans tip.
            Arac A1 = new Arac("Mercedes","Sls-amg",2019);
        }
    }
}
