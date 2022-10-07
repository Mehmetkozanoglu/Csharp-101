using System;
using System.Collections;
using System.Collections.Generic;

namespace Odev2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayılar = new ArrayList();
          for(int i = 0; i < 20; i++)
          {
            Console.WriteLine("Lütfen {0}.sayıyı giriniz:",i+1);
            int n = int.Parse(Console.ReadLine());
            sayılar.Add(n);
          }
          sayılar.Sort();
          foreach(var item in sayılar)
          {
          Console.WriteLine(item);
          }
          ArrayList minsayı = sayılar.GetRange(0,3);
          ArrayList maxsayı = sayılar.GetRange(17,3);
            foreach(var item in minsayı)
            Console.WriteLine(item);
            foreach(var item in maxsayı)
            Console.WriteLine(item);
            ListeYazdir(minsayı);
            ListeYazdir(maxsayı);
            Console.WriteLine("En küçük 3 sayının ortalaması: "+OrtalamaYazdir(minsayı));
            Console.WriteLine("En büyük 3 sayının ortalaması: "+OrtalamaYazdir(maxsayı));
            Console.WriteLine("Toplam ortalama: "+ (OrtalamaYazdir(minsayı)+OrtalamaYazdir(maxsayı)));

        }
                static void ListeYazdir(ArrayList liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.Write(liste[i] + " ");
            }
            Console.WriteLine();
        }
        static double OrtalamaYazdir(ArrayList liste)
        {
            int toplam = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                toplam += Convert.ToInt32(liste[i]);
            }
            double ortalama = (double)toplam / liste.Count;
            return ortalama;
        }
    }
}
