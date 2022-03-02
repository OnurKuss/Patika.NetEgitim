using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            Console.WriteLine("cümle girin");
            string veri = Console.ReadLine();

            char[] cumle = veri.ToCharArray();
            List<char> cumledeliSesliHarfler = new List<char>();

            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (cumle[i]==sesliHarfler[j])
                    {
                        cumledeliSesliHarfler.Add(cumle[i]);
                    }
                }
            }

            foreach (char c in cumledeliSesliHarfler)
            {
                Console.Write(c+ " ");
            }
        }
    }
}
