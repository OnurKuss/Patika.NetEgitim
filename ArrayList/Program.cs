using System;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            //list.Add("Ayşe");
            //list.Add(2);
            //list.Add(true);
            //list.Add('a');

            //foreach (var VARIABLE in list)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            Console.WriteLine("-------Add Range------");
            //string[] renkler = {"sarı", "kırmızı", "mor", "mavi"};
            List<int> sayilar = new List<int>(){1, 4, 6, 2, 8, 5};

            //list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            //Sort 
            Console.WriteLine("------Sort------");
            list.Sort(); //compiler time da hata oluşmazken run time da içerisinde farklı veri tiplerinin olmasından hata verir

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------Binary Search-----");
            //Binary Search --> önce sıralayıp sonra arama yapmalıyız
            Console.WriteLine(list.BinarySearch(6));


            Console.WriteLine("------Reverse-----");
            //reverse 
            list.Reverse();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
