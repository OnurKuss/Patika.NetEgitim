using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberUygulaması
{
    public class PersonInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }

        public PersonInfo(string firstName,string lastName, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public PersonInfo()
        {
            
        }
    }
}
