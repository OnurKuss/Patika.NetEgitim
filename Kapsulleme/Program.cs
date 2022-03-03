using System;

namespace Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(isim:"Onur",soyisim:"Kuş",622,12);
            ogrenci1.SinifAtlat();

            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get; set; }
        public int OgrenciNo { get; set; }

        public int Sinif
        {
            get { return sinif;}
            set
            {
                if (value<1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir!!");
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public Ogrenci(string isim, string soyisim,int ogrenciNo,int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********Ogrenci Bilgileri*********");
            Console.WriteLine("Adi: {0}", Isim);
            Console.WriteLine("Soyad: {0}", Soyisim);
            Console.WriteLine("No: {0}",OgrenciNo);
            Console.WriteLine("Sınıf: {0}", Sinif);
        }

        public void SinifAtlat()
        {
            Sinif++;
        }
        public void SinifDusur()
        {
            Sinif--;
        }
        
    }

}
