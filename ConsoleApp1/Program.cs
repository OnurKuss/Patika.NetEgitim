using System;

namespace RefVeOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int sonuc = Program.ArttırVeTopla(ref x, ref y);
            Console.WriteLine(sonuc);

            int sonuc2= Program.Toplam(4, 6, out int toplam);
            Console.WriteLine(sonuc2);
        }
        public static int ArttırVeTopla(ref int x, ref int y)
        {
            x += 1;
            y += y;
            return (x + y);
        }

        public static int Toplam(int a, int b, out int toplam)
        {
            toplam = a + b;
            return toplam;
        }


    }
}
