using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Adress
    {

        public string gatuAdress;
        public string stad;
        public string postnummer;

        public Adress(string g, string s, string p)
        {
            gatuAdress = g;
            stad = s;
            postnummer = p;
        }
    }
}
