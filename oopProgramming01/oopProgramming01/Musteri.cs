using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProgramming01
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public string TCkimlikNumara;
        public int cinsiyet; //71777001-bay , 71777002-bayan olarak tutulacaktır.
     
        // Yapıcı Metot ctor
        // Yapıcı metot kullanarak ezeriz ve nesne oluştuğunda default değerleri değil istediğimiz değerleri alır.
        public Musteri()
        {
            TCkimlikNumara = "15487986532";
        }
        public Musteri(string isim, string soyisim, string tCkimlikNumara)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            TCkimlikNumara = tCkimlikNumara;
        } 
        public Musteri(string _isim)
        {
            this.isim = _isim;
        }
        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TCkimlikNumara);
            return kontrol;
        }


        private bool MusteriKontrolDatabase(string TCkimlikno)
        {
            //database e gidilir ve müsterinin TCsi var mı yok mu sorgusu yapılır.
            return true;
        }
    }
}
