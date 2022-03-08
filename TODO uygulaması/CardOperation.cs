using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_uygulaması.Board;

namespace TODO_uygulaması
{
    public class CardOperation : ICardOperation
    {
        public void AddToCard(Card card)
        {

            ToDoLine.ListOfToDo.Add(card);

        }

        public void DeleteToCard()
        {
            Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine(" Lütfen kart başlığını yazınız:");
            string cardTittle = Console.ReadLine();
            bool status = false;
            if (cardTittle.Length > 0)
            {
                foreach (var item in ToDoLine.ListOfToDo.ToArray())
                {
                    int durum = ToDoLine.ListOfToDo.RemoveAll(b => b.Baslik == cardTittle);
                    if (durum > 0)
                    {
                        status = true;
                    }

                }

                foreach (var item in InProgressLine.ListOfInProgress.ToArray())
                {
                    int durum2 = InProgressLine.ListOfInProgress.RemoveAll(b => b.Baslik == cardTittle);
                    if (durum2 > 0)
                    {
                        status = true;
                    }
                }

                foreach (var item in DoneLine.ListOfDone.ToArray())
                {
                    int durum3= DoneLine.ListOfDone.RemoveAll(b => b.Baslik == cardTittle);
                    if (durum3 > 0)
                    {
                        status = true;
                    }
                }

            }

            if (status == false)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");
                int read = int.Parse(Console.ReadLine());
                if (read == 1)
                {
                    Console.Clear();
                }
                else if (read == 2)
                {
                    DeleteToCard();
                }

            }
        }

        public void ListToCard()
        {
            Console.WriteLine(" TODO Line");
            Console.WriteLine(" ************************");
            var ToDoArray = ToDoLine.ListOfToDo.ToArray();
            foreach (var item in ToDoArray)
            {
                Console.WriteLine(" Başlık      :" + item.Baslik);
                Console.WriteLine(" İçerik      :" + item.Icerik);
                Console.WriteLine(" Atanan Kişi :" + item.Id);
                Console.WriteLine(" Büyüklük    :" + item.Size);
                Console.WriteLine("-");
            }

            Console.WriteLine(" IN PROGRESS Line");
            Console.WriteLine(" ************************");
            var InProgressArray = InProgressLine.ListOfInProgress.ToArray();
            foreach (var item in InProgressArray)
            {
                Console.WriteLine(" Başlık      :" + item.Baslik);
                Console.WriteLine(" İçerik      :" + item.Icerik);
                Console.WriteLine(" Atanan Kişi :" + item.Id);
                Console.WriteLine(" Büyüklük    :" + item.Size);
                Console.WriteLine("-");
            }

            Console.WriteLine(" DONE Line");
            Console.WriteLine(" ************************");
            var DoneArray = InProgressLine.ListOfInProgress.ToArray();
            foreach (var item in DoneArray)
            {
                Console.WriteLine(" Başlık      :" + item.Baslik);
                Console.WriteLine(" İçerik      :" + item.Icerik);
                Console.WriteLine(" Atanan Kişi :" + item.Id);
                Console.WriteLine(" Büyüklük    :" + item.Size);
                Console.WriteLine("-");
            }

        }

        public void MoveToCard()
        {
            throw new NotImplementedException();
        }

        public void UpdateToCard()
        {
            throw new NotImplementedException();
        }
    }
}
