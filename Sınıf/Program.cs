using System;

namespace Sınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan("Hasan","Turan",1,"İnsan Kaynakları");

            calisan.CalisanBilgileri();
        
            Console.WriteLine("------------");

            Calisan calisan2 = new Calisan
            {
                Ad = "Arda", Soyad = "Turan", No = 2, Departman = "Satın Alma"
            };

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }

        public Calisan()
        {
            
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi: {0}", Ad);
            Console.WriteLine("Calisan Soyad: {0}", Soyad);
            Console.WriteLine("Calisan No: {0}", No);
            Console.WriteLine("Calisan Departman: {0}", Departman);
        }
    }
}
