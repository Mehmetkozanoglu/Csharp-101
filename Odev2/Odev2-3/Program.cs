using System;

namespace Koleksiyonlar_Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Lütfen cümle giriniz:");
          string cümle = Console.ReadLine();
          SesliBulma(cümle);
        }
        static void SesliBulma(string cümle)
        {
        char [] harfler = new char[cümle.Length];
        List<char> sesliharf = new List<char>(){'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};
        for(int i =0 ; i<cümle.Length;i++)
        if(sesliharf.Contains(cümle[i]))
        Console.WriteLine(cümle[i]+"'");
        }
    }
}