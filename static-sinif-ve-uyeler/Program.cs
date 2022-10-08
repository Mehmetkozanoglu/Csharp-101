using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı :"+Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Aydın","İnsan Kaynakları");
            Console.WriteLine("Çalışan Sayısı :"+Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz","Ürkmez","İnsan Kaynakları");
            Calisan calisan2 = new Calisan("Necla","Ateş","İnsan Kaynakları");
            Console.WriteLine("Çalışan Sayısı :"+Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: "+Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: "+Islemler.Cıkar(100,200));



        }
    }
    class Calisan
    {
        private static int calisanSayisi; 
         public static int CalisanSayisi 
        {
            get{ return calisanSayisi; }      
        }  

        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan ()
        {
            calisanSayisi = 0;      
        }
        public Calisan(string isim , string soyisim , string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cıkar (int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
