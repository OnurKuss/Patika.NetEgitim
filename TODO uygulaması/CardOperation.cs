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

        public static Card Add()
        {
            Console.WriteLine(" Başlık Giriniz                                  :");
            string tittle = Console.ReadLine();
            Console.WriteLine(" İçerik Giriniz                                  :");
            string content = Console.ReadLine();
            Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(" Kişi Seçiniz                                    :");
            int personId = int.Parse(Console.ReadLine());
            if (size<6 && size>0 && personId<6 && personId>0)
            {
                Card card = new Card(tittle, content, personId, size);
                return card;
            }
            Console.WriteLine("Boyut ya da kişi id'si hatalı girilmiştir!!");
            return null;
            
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
                Console.WriteLine(" Büyüklük    :" + EnumToSize(item.Size));
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
                Console.WriteLine(" Büyüklük    :" + EnumToSize(item.Size));
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
                Console.WriteLine(" Büyüklük    :" + EnumToSize(item.Size));
                Console.WriteLine("-");
            }

        }

        public static string EnumToSize(int size)
        {
            if (size==1)
            {
                return Size.XS.ToString();
            }
            else if (size == 2)
            {
                return Size.S.ToString();
            }
            else if (size == 3)
            {
                return Size.M.ToString();
            }
            else if (size == 4)
            {
                return Size.L.ToString();
            }
            else if (size == 5)
            {
                return Size.XL.ToString();
            }
            return null;

        }

        public void MoveToCard()
        {
            Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine(" Lütfen kart başlığını yazınız:");
            string tittle = Console.ReadLine();
            var toDoArray = ToDoLine.ListOfToDo.ToArray();
            var inProgressArray = InProgressLine.ListOfInProgress.ToArray();
            var doneLineArray = DoneLine.ListOfDone.ToArray();
            var isExist = toDoArray.FirstOrDefault(t => t.Baslik == tittle);
            var isExist2 = inProgressArray.FirstOrDefault(t => t.Baslik == tittle);
            var isExist3 = doneLineArray.FirstOrDefault(t => t.Baslik == tittle);
            if (isExist!=null)
            {
                Console.WriteLine(" Bulunan Kart Bilgileri:");
                Console.WriteLine(" **************************************");
                Console.WriteLine(" Başlık      : " + isExist.Baslik);
                Console.WriteLine(" İçerik      : " + isExist.Icerik);
                Console.WriteLine(" Atanan Kişi : " + isExist.Id);
                Console.WriteLine(" Büyüklük    : " + isExist.Size);
                Console.WriteLine(" Line        : ToDo Line");
            }
            else if (isExist2 != null)
            {
                Console.WriteLine(" Bulunan Kart Bilgileri:");
                Console.WriteLine(" **************************************");
                Console.WriteLine(" Başlık      : " + isExist2.Baslik);
                Console.WriteLine(" İçerik      : " + isExist2.Icerik);
                Console.WriteLine(" Atanan Kişi : " + isExist2.Id);
                Console.WriteLine(" Büyüklük    : " + isExist2.Size);
                Console.WriteLine(" Line        : InProgress Line");
            }
            else
            {
                Console.WriteLine(" Bulunan Kart Bilgileri:");
                Console.WriteLine(" **************************************");
                Console.WriteLine(" Başlık      : " + isExist3.Baslik);
                Console.WriteLine(" İçerik      : " + isExist3.Icerik);
                Console.WriteLine(" Atanan Kişi : " + isExist3.Id);
                Console.WriteLine(" Büyüklük    : " + isExist3.Size);
                Console.WriteLine(" Line        : Done Line");
            }

        }

        public void UpdateToCard()
        {
            throw new NotImplementedException();
        }
    }
}
