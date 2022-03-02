using System;

namespace StringKütüphanesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz";
            string degisken2 = "Dersimiz CSharp";

            //length
            Console.WriteLine(degisken.Length);

            //ToUpper, tolower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            
            //concat
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            //compare - compare to
            Console.WriteLine(degisken.CompareTo(degisken2)); //karakter sayıları eşit ise 0 
                                                              // degisken karakter sayısı fazla ise 1 , diğeri fazla ise -1
            Console.WriteLine(String.Compare(degisken,degisken2,true));

            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Günaydın"));

            //indexof
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.LastIndexOf("Hoşgeldiniz"));
            Console.WriteLine("---------");

            //insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));
            
            //Padleft , Padrigth
            Console.WriteLine(degisken+ degisken2.PadLeft(30,'o'));

            //remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

            string s = Console.ReadLine();
            char[] dizi = s.ToCharArray();
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);
            }
        }
    }
}
