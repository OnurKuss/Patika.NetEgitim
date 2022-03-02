using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(8);
            sayiListesi.Add(54);
            sayiListesi.Add(15);
            sayiListesi.Add(29);
            sayiListesi.Add(45);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Turuncu");

            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);


            //Foreach ile elemanlara erişim
            foreach (int i in sayiListesi)
            {
                Console.WriteLine(i);
            }

            foreach (string s in renkListesi)
            {
                Console.WriteLine(s);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(8);
            renkListesi.Remove("Yeşil");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //liste içerisinde arama
            if (sayiListesi.Contains(15))
            {
                Console.WriteLine("Liste içerisinde bulundu");
            }

            //eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("turuncu"));

            //diziyi liste cevirme
            string[] hayvanlar = {"kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi temizleme
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanici> kullanıcıListesi = new List<Kullanici>();
            Kullanici user = new Kullanici();
            user.Isim = "Onur";
            user.Soyisim = "kuş";
            user.Yas = 23;
            kullanıcıListesi.Add(user);

            foreach (var kullanici in kullanıcıListesi)
            {
                Console.WriteLine(kullanici.Isim);
            }

            Console.WriteLine("**************");
            int[] sayilar = {1, 2, 3, 4, 5};
            PrintArray(sayilar);
        }

        public static void PrintArray<T>(T[] dizi)
        {
            foreach (var i in dizi)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Kullanici
    {
        private string isim;
        private string soyisim;
        private int yas;
        public string Isim { get => isim; set => isim=value; }
        public string Soyisim { get => soyisim; set => soyisim=value; }
        public int Yas { get => yas; set => yas=value; }
    }

    
}
