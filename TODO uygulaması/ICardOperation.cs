using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_uygulaması
{
    public interface ICardOperation
    {
        void AddToCard(Card card);
        void DeleteToCard();
        void UpdateToCard();
        void ListToCard();
        void MoveToCard();
    }
}
