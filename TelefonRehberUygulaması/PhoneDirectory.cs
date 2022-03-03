using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberUygulaması
{
    public class PhoneDirectory : IPhoneDirectory
    {
        public PhoneDirectory()
        {
            PersonInfo person1 = new PersonInfo("Hakan", "Yılmaz", "16511651");
            PersonInfo person2 = new PersonInfo("Barış", "Dogan", "156161565");
            PersonInfo person3 = new PersonInfo("Ayşe", "Duru", "588586474");
            PersonInfo person4 = new PersonInfo("Melek", "", "498448846");
            PersonInfo person5 = new PersonInfo("Hakan", "Yılmaz", "1651616586");
            Directory.rehber.Add(person1);
            Directory.rehber.Add(person2);
            Directory.rehber.Add(person3);
            Directory.rehber.Add(person4);
            Directory.rehber.Add(person5);
        }
        public void AddNumber()
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string number = Console.ReadLine();
            Directory.rehber.Add(new PersonInfo(firstName, lastName, number));

        }

        public void DeleteNumber()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            int check = 0;
            string name = Console.ReadLine();
            foreach (var item in Directory.rehber)
            {
                if (item.FirstName.ToLower() == name.ToLower() || item.LastName.ToLower() == name.ToLower())
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", name);
                    char control = char.Parse(Console.ReadLine());
                    if (control == 'y')
                    {
                        int deleteIndex = Directory.rehber.IndexOf(item);
                        Directory.rehber.RemoveAt(deleteIndex);
                        check++;
                        Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                        break;
                    }
                    else
                    {
                        check++;
                        Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                        break;
                    }

                }
            }

            if (check == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 2)
                {
                    while (selection == 2)
                    {
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        name = Console.ReadLine();
                        foreach (var item2 in Directory.rehber)
                        {

                            if (item2.FirstName.ToLower() == name.ToLower() ||
                                item2.LastName.ToLower() == name.ToLower())
                            {
                                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",
                                    name);
                                char control = char.Parse(Console.ReadLine());
                                if (control == 'y')
                                {
                                    int deleteIndex = Directory.rehber.IndexOf(item2);
                                    Directory.rehber.RemoveAt(deleteIndex);
                                    check++;
                                    selection = 3;
                                    Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                                    break;
                                }
                                else
                                {
                                    check++;
                                    selection = 3;
                                    Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                                    break;
                                }
                            }
                        }

                        if (check == 0)
                        {
                            Console.WriteLine(
                                "Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için      : (2)");
                            selection = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }

        }

        public void GetDirectory()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            for (int i = 0; i < Directory.rehber.Count; i++)
            {
                Console.WriteLine("isim: {0}", Directory.rehber[i].FirstName);
                Console.WriteLine("Soyisim: {0}", Directory.rehber[i].LastName);
                Console.WriteLine("Telefon Numarası: {0}", Directory.rehber[i].Number);
                Console.WriteLine("-");
            }
        }

        public void SearchDirectory()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını ya da soyadını giriniz:");
                string name = Console.ReadLine();
                foreach (var item in Directory.rehber)
                {
                    if (item.FirstName.ToLower() == name.ToLower() || item.LastName.ToLower() == name.ToLower())
                    {
                        Console.WriteLine("isim: {0}", item.FirstName);
                        Console.WriteLine("Soyisim: {0}", item.LastName);
                        Console.WriteLine("Telefon Numarası: {0}", item.Number);
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");
            }
            else if (select == 2)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin telefon numarasını giriniz:");
                string no = Console.ReadLine();
                foreach (var item in Directory.rehber)
                {
                    if (item.Number == no)
                    {
                        Console.WriteLine("isim: {0}", item.FirstName);
                        Console.WriteLine("Soyisim: {0}", item.LastName);
                        Console.WriteLine("Telefon Numarası: {0}", item.Number);
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");
            }
            else
            {
                Console.WriteLine("Hatalı Seçim, Çıkılıyor...");
            }
        }

        public void UpdateNumber()
        {

            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string name = Console.ReadLine();
            int count = Directory.rehber.Count;
            int updateControl = 0;
            //Foreach Kullanamıyoruz, çünkü hangi indeks de iş yapıyorsak orayı bilmemiz lazım, çünkü güncelleme yapacağız :).
            for (var i = 0; i < count; i++)
            {
                if (Directory.rehber[i].FirstName.ToLower() == name.ToLower() || Directory.rehber[i].LastName.ToLower() == name.ToLower())
                {
                    Console.WriteLine("Kişi Bulundu ve Telefon Numarası: {0}", Directory.rehber[i].Number);
                    Console.WriteLine("Lütfen güncellemek istediğiniz telefon numarasını giriniz...");
                    string newNumber = Console.ReadLine();
                    Directory.rehber[i].Number = newNumber;
                    Console.WriteLine("Telefon Numarası Güncellemesi Başarılı, Çıkılıyor...");
                    updateControl++;
                    break;
                }
            }
            if (updateControl == 0)
            {
                Console.WriteLine("Telefon Numarası Güncellemesi Başarısız, Çıkılıyor...");
            }

        }
    }
}
