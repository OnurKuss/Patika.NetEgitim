using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10,"Ayşe yılmaz");
            kullanıcılar.Add(12,"Ahmet Yılmaz");
            kullanıcılar.Add(13,"Deniz Arda");
            kullanıcılar.Add(20,"Özcan Deniz");

            //Dizinin elemanlarına erişim
            Console.WriteLine("-----Elemanlara erişim-----");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var i in kullanıcılar)
            {
                Console.WriteLine(i);
            }

            //count
            Console.WriteLine("-----Count------");
            Console.WriteLine(kullanıcılar.Count);

            //contains
            Console.WriteLine("-----Contains------");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Onur Kuş"));

            //Remove
            Console.WriteLine("------Remove-------");
            kullanıcılar.Remove(12);
            foreach (var i in kullanıcılar)
                Console.WriteLine(i);

            //key 
            Console.WriteLine("------Key-------");
            foreach (var key in kullanıcılar)
            {
                Console.WriteLine(key.Key);
            }

            //values
            Console.WriteLine("------Values-------");
            foreach (var value in kullanıcılar)
            {
                Console.WriteLine(value.Value);
            }


            int n = Int32.Parse(Console.ReadLine());
            var phonebook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                string name = s[0];
                string number = s[1];
                phonebook.Add(name,number);
            }

            foreach (var i in phonebook)
            {
                Console.WriteLine(i);
            }

        }
    }
}
