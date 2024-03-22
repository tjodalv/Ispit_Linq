using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Podaci
    {
        public List<Banka>? ListaBanki { get; }
        public List<Klijent>? ListaKlijenata { get; }

        public Podaci()
        {
            ListaBanki = new List<Banka> {
                new Banka("ZABA", "Zagrebačka banka"),
                new Banka("PBZ", "Privredna banka Zagreb"),
                new Banka("ERSTE", "Erste&Steiermaerkische bank")
            };

            ListaKlijenata = new List<Klijent>
            {
                new Klijent("Antonio Božić", 100000, "PBZ"),
                new Klijent("Luka Purić", 150000, "ERSTE"),
                new Klijent("Ivan Zekić", 1200000, "ZABA"),
                new Klijent("Pero Gerić", 250000, "ZABA"),
                new Klijent("Marko Vranić", 300000, "PBZ"),
                new Klijent("Iva Jokić", 350000, "ERSTE"),
                new Klijent("Sanja Klopić", 500000, "PBZ"),
                new Klijent("Ana Babić", 700000, "ZABA"),
                new Klijent("Mara Klarić", 1200000, "ERSTE"),
                new Klijent("Ava Dedić", 1050000, "PBZ"),
                new Klijent("Jozo Jozić", 20000000, "ZABA")
            };
        }
    }
}
