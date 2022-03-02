using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girmek isteğiniz sayı adetini giriniz: ");
            int n = int.Parse(Console.ReadLine());
            ArrayList primeNumber = new ArrayList();
            ArrayList nonPrimeNum = new ArrayList();

            Console.WriteLine($"{n} adet sayı girin");
            for (int i = 0; i < n; i++)
            {
                int sayi= int.Parse(Console.ReadLine());
                while(sayi>0)
                {
                    if (AsalMı(sayi))
                    {
                        primeNumber.Add(sayi);
                        break;
                    }
                    else
                    {
                        nonPrimeNum.Add(sayi);
                        break;
                    }
                }
            }
            
            primeNumber.Sort();
            primeNumber.Reverse();
            Console.WriteLine("Asal Sayılar: ");
            foreach (var i in primeNumber)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Eleman Sayısı: " + primeNumber.Count);
            Console.WriteLine("Ortalama: " + ((double)Topla(primeNumber)/ (double)primeNumber.Count));

            nonPrimeNum.Sort();
            nonPrimeNum.Reverse();
            Console.WriteLine("Asal Olmayan Sayılar: ");
            int sum = 0;
            foreach (var i in nonPrimeNum)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Eleman Sayısı: " + nonPrimeNum.Count );
            Console.WriteLine("Ortalama: " + ((double)Topla(nonPrimeNum) / (double)nonPrimeNum.Count));

        }

        static bool AsalMı(int sayi)
        {
            
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int Topla(ArrayList list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += (int) list[i];
            }

            return sum;
        }
    }
}
