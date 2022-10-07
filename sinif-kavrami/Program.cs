using System;

namespace sinif_kavrami
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
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Huriye";
            calisan1.Soyad = "Bağzıbağlı";
            calisan1.No = 15467546;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Nariye";
            calisan2.Soyad = "Aysan";
            calisan2.No = 87531528;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();

        }
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

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
