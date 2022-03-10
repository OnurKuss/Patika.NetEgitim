using System;
using TODO_uygulaması;

namespace TODO_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();

            CardOperation cardOperation = new CardOperation();

            cardOperation.AddToCard(new Card(".NET", "Odev", 1, 1));
            cardOperation.AddToCard(new Card(".NET2", "Odev2", 2, (int)Size.S));
            cardOperation.AddToCard(new Card(".NET3", "Odev3", 3, (int)Size.M));
            MainList(cardOperation);

            Console.WriteLine("Tekrar denemek için 1'e basınız");
            int choose2 = int.Parse(Console.ReadLine());
            if (choose2 == 1)
            {
                Start();
                MainList(cardOperation);
            }




        }

        private static void Start()
        {
            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" *******************************************");

            Console.WriteLine(" (1) Board Listelemek");
            Console.WriteLine(" (2) Board'a Kart Eklemek");
            Console.WriteLine(" (3) Board'dan Kart Silmek");
            Console.WriteLine(" (4) Kart Taşımak");
        }

        private static void MainList(CardOperation cardOperation)
        {
            int choose = int.Parse(Console.ReadLine());

            if (choose > 0 && choose < 5)
            {
                if (choose == 1)
                {
                    cardOperation.ListToCard();
                }
                else if (choose == 2)
                {
                    cardOperation.AddToCard(CardOperation.Add());
                }
                else if (choose == 3)
                {
                    cardOperation.DeleteToCard();
                }
                else if(choose==4)
                {
                    cardOperation.MoveToCard();
                }
            }
        }
    }
}
