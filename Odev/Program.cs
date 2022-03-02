using System;
using System.Linq;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen sayiların çift olanlarını bastıran program

            //Console.Write("Lütfen pozitif bir sayı giriniz: ");
            //int n=Int32.Parse(Console.ReadLine());

            //Console.Write($"lütfen {n} adet sayı giriniz: ");
            //int[] sayilar = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //     int sayi=Convert.ToInt32(Console.ReadLine());
            //     sayilar[i] = sayi;
            //}

            //Console.Write("Çift sayilar: ");
            //foreach (int i in sayilar)
            //{
            //    if (i%2==0)
            //    {
            //        Console.Write(i+ ", ");
            //    }
            //}



            //Console.WriteLine("lütfen iki adet sayi giriniz: ");
            //int n, m;
            //n=Int32.Parse(Console.ReadLine()); 
            //m=Int32.Parse(Console.ReadLine());

            //Console.WriteLine($"lütfen {n} adet sayı giriniz");
            //int[] sayilar = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    int sayi= Convert.ToInt32(Console.ReadLine());
            //    sayilar[i] = sayi;
            //}

            //foreach (int i in sayilar)
            //{
            //    if (i==m || i%m==0)
            //    {
            //        Console.Write(i + ", ");
            //    }
            //}




            //Console.Write("Lütfen pozitif bir sayı giriniz: ");
            //int n=Int32.Parse(Console.ReadLine());

            //Console.WriteLine($"lütfen {n} adet kelime giriniz");
            //string[] kelimeler = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    kelimeler[i] = Console.ReadLine();
            //}
            //Array.Reverse(kelimeler);
            //foreach (string s in kelimeler)
            //{
            //    Console.WriteLine(s);
            //}


            Console.WriteLine("lütfen bir cümle giriniz: ");
            string s = Console.ReadLine();
            string[] s2 = s.Split(" ");
            Console.Write("Toplam kelime sayısı: " + s2.Length);
            Console.WriteLine();
            int harfsayisi = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                char[] harfdizi = s2[i].ToCharArray();
                harfsayisi += harfdizi.Length;
            }
            Console.WriteLine($"Toplam harf sayısı: {harfsayisi}");
        }
    }
}
