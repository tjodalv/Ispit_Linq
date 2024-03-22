using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model.Klase
{
    public class Klijent
    {
        public string ImePrezime {  get; }
        public double Stanje { get; }
        public string Banka { get; }

        public Klijent(string imePrezime, double stanje, string banka)
        {
            ImePrezime = imePrezime;
            Stanje = stanje;
            Banka = banka;
        }
        public bool jeMilijunas()
        {
            return (Stanje >= 1000000);
        }
    }
}
