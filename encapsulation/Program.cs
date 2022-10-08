using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Aydın";
            ogrenci.OgrenciNo =300;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();
            
            Console.WriteLine();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Console.WriteLine();

            Ogrenci ogrenci1 = new Ogrenci("Yeşim","Sever",256,1);
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();


        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        {
            get{ return isim; }
            set { isim = value; }
        }
        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value;}
        }
        public int OgrenciNo 
        {
            get{ return ogrenciNo; }
            set { ogrenciNo = value; }
        }
        public int Sinif 
        {
            get{ return sinif; }
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir");
                    sinif = 1;
                } 
                else
                sinif = value; 
            }
        }
        public Ogrenci(string isim , string soyisim , int ogrenciNo , int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
              public Ogrenci()
        {

        }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Öğrenci Adı: "+this.Isim);
            Console.WriteLine("Öğrenci Soyadı: "+this.Soyisim);
            Console.WriteLine("Öğrenci No: "+this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı: "+this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
         public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }   
}
