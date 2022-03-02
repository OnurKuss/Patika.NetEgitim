using System;
using System.Linq;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sayilar);
            int smallNum = 0;
            for (int i = 0; i < 3; i++)
            {
                smallNum += sayilar[i];
            }
            Array.Reverse(sayilar);
            int bigNum = 0;
            for (int i = 0; i < 3; i++)
            {
                bigNum += sayilar[i];
            }
            
            Console.WriteLine($"En küçük sayıların ortalamaları: {smallNum/3}");
            Console.WriteLine($"En büyük sayıların ortalamaları: {(float)bigNum/3}");
            Console.WriteLine($"Ortalama Toplamları: {(float)(bigNum / 3)+(float)(smallNum/3)}");







        }
    }
}
