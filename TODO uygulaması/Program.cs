using System;
using TODO_uygulaması;

namespace TODO_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" *******************************************");

            Console.WriteLine(" (1) Board Listelemek");
            Console.WriteLine(" (2) Board'a Kart Eklemek");
            Console.WriteLine(" (3) Board'dan Kart Silmek");
            Console.WriteLine(" (4) Kart Taşımak");

            CardOperation cardOperation = new CardOperation();

            cardOperation.AddToCard(new Card(".NET", "Odev", 1 , 1));
            cardOperation.AddToCard(new Card(".NET2", "Odev2", 2, (int)Size.S));
            cardOperation.AddToCard(new Card(".NET3", "Odev3", 3, (int)Size.M));

            int choose = int.Parse(Console.ReadLine());

            if (choose==1)
            {
                cardOperation.ListToCard();
            }
            else if (choose==2)
            {

            }
            else if (choose==3)
            {
                cardOperation.DeleteToCard();
            }
            
        }
    }
}
