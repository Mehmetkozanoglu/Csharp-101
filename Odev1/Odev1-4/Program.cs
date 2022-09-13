using System;

namespace Odev1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string ifade = Console.ReadLine();

            string[] kelimeDizisi = ifade.Split(" ");
            int kelimeSayisi = kelimeDizisi.Length;

            string harfDizisi = string.Join("",kelimeDizisi);

            char[]harf = harfDizisi.ToCharArray();
            int harfSayisi = harf.Length;

            Console.WriteLine("Girilen cümledeki toplam kelime sayisi:{0}", kelimeSayisi);
            Console.WriteLine("Girilen cümledeki toplam harf sayisi:{0}", harfSayisi);
        }
    }
}
