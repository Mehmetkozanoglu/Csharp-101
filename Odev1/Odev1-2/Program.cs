using System;

namespace Odev1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Lütfen pozitif iki sayi giriniz: ");
                int[] sayiConsole = new int[2];
                for (int i = 0; i < sayiConsole.Length; i++)
                {
                    Console.Write("{0}.sayi: ", i + 1);
                    sayiConsole[i] = Convert.ToInt32(Console.ReadLine());
                }
                int n = sayiConsole[0];
                int m = sayiConsole[1];

                Console.WriteLine("Lütfen {0} adet pozitif bir sayı giriniz: ", n);
                int[] sayiDizisi = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}.sayi: ", i + 1);
                    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("{0} sayısına eşit ya da tam bölünen sayılar", m);
                foreach (int sayi in sayiDizisi)
                {
                    if (sayi == m || sayi % m == 0)
                    {
                        Console.WriteLine(sayi);
                    }
                 }
                }   
                catch(Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message.ToString());
            }
        }
    }
}
