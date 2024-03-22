using Ispit.Model;
using Ispit.Model.Klase;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Podaci baza = new Podaci();

            var sviMilijunasi = baza.ListaKlijenata
                .Where(klijent => klijent.jeMilijunas());

            var GrupirajPremaBanci = sviMilijunasi
                .Where(klijent => klijent.jeMilijunas())
                .GroupBy(klijent => klijent.Banka)
                .Select(group => new GrupiraniMilijunasi {
                    Banka = group.Key,
                    Milijunasi = group.Select(klijent => klijent.ImePrezime)
                })
                .ToList();

            Console.WriteLine("Milijunaši po bankama:");
            Console.WriteLine("-------------------------");

            foreach (var grupa in GrupirajPremaBanci)
            {
                string milijunasi = string.Join(", ", grupa.Milijunasi);

                Console.WriteLine($"{grupa.Banka}: {milijunasi}");
            }

            Console.WriteLine("");

            var milijunasiLista = sviMilijunasi.ToList();

            Console.WriteLine("Izvještaj milijunaša:");
            Console.WriteLine("-------------------------");

            foreach (var klijent in milijunasiLista)
            {
                var banka = baza.ListaBanki.FirstOrDefault(bank => bank.Simbol == klijent.Banka);
                string nazivBanke = banka != null ? banka.Naziv : "ERR: Nepoznata banka";

                Console.WriteLine($"{klijent.ImePrezime} je u {nazivBanke}");
            }
        }
    }
}
