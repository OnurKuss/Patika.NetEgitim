using System;

namespace DatetimeAndMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));

            //DateTime format
            Console.WriteLine(DateTime.Now.ToString("dd")); //01
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sal
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Salı

            Console.WriteLine(DateTime.Now.ToString("MM"));//01
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Mar
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Mart

            Console.WriteLine(DateTime.Now.ToString("yy"));//22
            Console.WriteLine(DateTime.Now.ToString("yyy"));//2022
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-45));
            Console.WriteLine(Math.Sin(45));
            Console.WriteLine(Math.Cos(90));

            Console.WriteLine(Math.Ceiling(22.3));//direk yukarı yuvarlar
            Console.WriteLine(Math.Round(22.3));//asagı yakın ise asagı yukarı yakın ise yukarı yuvarlar
            Console.WriteLine(Math.Floor(22.7));//direk asagı yuvarlar

            Console.WriteLine(Math.Min(2,5));
            Console.WriteLine(Math.Max(3,23));

            Console.WriteLine(Math.Pow(3,4)); //3^4=81
            Console.WriteLine(Math.Sqrt(9)); // 3
            double sonuc = 3.4;
            int son = (int)Math.Ceiling(sonuc);
        }
    }
}
