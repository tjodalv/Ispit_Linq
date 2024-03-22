using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model.Klase
{
    public class Banka
    {
        public string Simbol { get; }

        public string Naziv { get; }

        public Banka(string simbol, string naziv)
        {
            Simbol = simbol;
            Naziv = naziv;
        }
    }
}
