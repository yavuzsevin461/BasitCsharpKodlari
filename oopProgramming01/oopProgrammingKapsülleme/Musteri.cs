using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProgrammingKapsülleme
{
    internal class Musteri
    {
        public Musteri()
        {
            this.id = IDUret();

        }
        // Class-->field
        int id;//bir şey yazılmazsaeğer private alınır..
        public int Id
        {
            get 
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string isim;
        public string soyisim;
        private string email;
        private int IDUret()
        {
            Random rnd=new Random();
            return rnd.Next(10000, 90000);
           
            
        }
        //Class-->properties
        public string Email
        {
            //get;// database veya farklı bir veri kaynağı.. class çağıran programcıya gösterdiğimiz kısım.
            //set;//dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atandığı kısım.
            set
            {
                this.email = value;
            }
            get
            {
                return this.email;
            }
        
        }


    }
}
