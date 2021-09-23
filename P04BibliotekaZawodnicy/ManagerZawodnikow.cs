using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04BibliotekaZawodnicy
{
    public class ManagerZawodnikow
    {
        private string url;
        private Zawodnik[] zawodnicy;
        public ManagerZawodnikow(string url)
        {
            this.url = url;
        }
        public void WczytajZawodnikow() // ta metoda uzupełnia prywatne pole zawodnicy
        {
            string dane = new WebClient().DownloadString(url);
            // splitujemy po znaku nowej linii
            // uzwamy przy okazji enumeratora, którego dziś poznaliśmy 
            string[] wiersze = dane.Split(new string[] { "\r\n" },  StringSplitOptions.RemoveEmptyEntries);
            // przyogotwujemy sobie tablice zawodników 
            // o długości mniejszej o 1 ponieważ pomijamy nagłowek 
            zawodnicy = new Zawodnik[wiersze.Length - 1];
            // dla kazdego wiersza bezdiemy transformować do zawodnika 
            for (int i = 1; i < wiersze.Length; i++)
            {
                // najpierw musimy rozbić wiersz na komórki 
                string[] komorki = wiersze[i].Split(';');

                // przygotowujmey nowego zawodnika
                Zawodnik z = new Zawodnik(komorki[2], komorki[3]);
                // teraz bedziemy uzupełniać jego pola 
                z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                if (!string.IsNullOrEmpty(komorki[1]))
                    z.Id_trenera = Convert.ToInt32(komorki[1]);

                //z.Imie = komorki[2];
                //z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);
                // jak uzupełnimy wszystkie pola to mozemy dodać
                // tego zawodnika do  wczesniej utworzonej tablicy
                zawodnicy[i - 1] = z;
            }     
        }
        
        public Zawodnik[] Filtruj(string kraj) // następnie filtrowanie jako źródło danych wykorzystuje prywatne pole zawodnicy 
        {
            // tworzymy liste zawodnikow bo nie wiemy ilu ich bedzie z danego kraju
            List<Zawodnik> przefiltrowani = new List<Zawodnik>();
            // dla kazdego zawodnika z naszego repozytorium lokalnego zawodnikow,
            //przechowywanego w postaci pola zawodnicy typu Zawodnik[]
            foreach (var z in zawodnicy)
                if (z.Kraj == kraj) // sprawdzamy czy ten zawodnik jest z szukanego kraju 
                    przefiltrowani.Add(z);// jesli tak to dodajemy go do lokalnej listy
            // ostataeczenie zwracamy tę listę przeroboną na tablice
            return przefiltrowani.ToArray();
        }
    }
}
