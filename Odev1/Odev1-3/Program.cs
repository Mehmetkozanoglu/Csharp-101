using System;

namespace Odev1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen {0} adet kelime giriniz:", n);
                string[]kelimeDizisi = new string[n];
                for(int i = 0; i < n; i++)
                kelimeDizisi[i] = Console.ReadLine();

                Array.Reverse(kelimeDizisi);
                Console.WriteLine("Sondan başa doğru girilen kelimeler");
                foreach(string kelime in kelimeDizisi)
                Console.WriteLine(kelime);
            }
                
                catch(Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message.ToString());
                }
       }
   }
}
