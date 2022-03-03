using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberUygulaması
{
    public interface IPhoneDirectory
    {
        void GetDirectory();
        void SearchDirectory();
        void AddNumber();
        void DeleteNumber();
        void UpdateNumber();
    }
}
