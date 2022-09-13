using System;

namespace Odev1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
          {
            Console.WriteLine("Pozitif bir sayı giriniz:");
            
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen {0} adet pozitif bir sayı giriniz:" , n);

            int[] sayiDizisi = new int[n];

            for (int i=0; i < n; i++)
            
            sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Çift Sayılar");
            int sayac = 0;
            foreach (int sayi in sayiDizisi)
            {
               if(sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                    sayac++;
                }
            }
            Console.WriteLine("{0} adet çift sayı bulundu.", sayac);
          }
          catch(OverflowException ex)
          {
            Console.WriteLine("Çok küçük ya da büyük bir değer girdiniz.");
            Console.WriteLine(ex);
          }
          catch(FormatException ex)
          {
            Console.WriteLine("Veri tipi uygun değil.");
            Console.WriteLine(ex);
          }
        }
    }
}
