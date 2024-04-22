using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Owner
    {

        public string firstName;
        public string lastName;
        public Adress address;

       public Owner(string f, string l, Adress a)
        {
            firstName = f;
            lastName = l;
            address = a;
        }

    }
}