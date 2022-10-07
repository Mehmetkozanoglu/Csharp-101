using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
         {
            //Söz Dizimi
            //Class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] OzellikAdi:
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi ([Parametre Listesi])
            //     {
            //         //Metot Komutları
            //     }
            // }
            // Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected
            Calisan calisan1 = new Calisan("Huriye", "Bağzıbağlı", 15467546 , "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Nariye";
            calisan2.Soyad = "Aysan";
            calisan2.No = 87531528;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan3 = new Calisan("Mehmet", "Kozanoğlu");
            calisan3.CalisanBilgileri();
            
            

        }
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        } 
        public Calisan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        } 
        public Calisan()
        {

        }
           

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı: "+ Ad);
                Console.WriteLine("Çalışan Soyadı: "+ Soyad);
                Console.WriteLine("Çalışan Numarası: "+ No);
                Console.WriteLine("Çalışan Departmanı: "+ Departman);
            }
        }
    }
}