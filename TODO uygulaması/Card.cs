using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_uygulaması
{
    public class Card
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int Id { get; set; }
        public int Size { get; set; }

        public Card(string baslik, string icerik, int id, int size)
        {
            Baslik = baslik;
            Icerik = icerik;
            Id = id;
            Size = size;
        }
    }

    enum Size
    {
        XS=1,
        S,
        M,
        L,
        XL
    }
}
