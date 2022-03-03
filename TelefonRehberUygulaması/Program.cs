using System;
using System.Collections.Generic;

namespace TelefonRehberUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory iDirectory = new PhoneDirectory();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Çıkmak İçin 1-5 Dışında Her Hangi Bir Şey Girmeniz Yeterlidir.");

            int select = int.Parse(Console.ReadLine());
            while (select >= 1 && select <= 5)
            {
                if (select==1)
                {
                    iDirectory.AddNumber();
                }
                else if (select==2)
                {
                    iDirectory.DeleteNumber();
                }
                else if (select == 3)
                {
                    iDirectory.UpdateNumber();
                }
                else if (select == 4)
                {
                    iDirectory.GetDirectory();
                }
                else if (select == 5)
                {
                    iDirectory.SearchDirectory();
                }
                else
                {
                    Console.WriteLine("1-5 Aralığı Dışında Bir Sayı Girildi, Çıkılıyor...");
                    break;
                }
            }





        }
    }
}
