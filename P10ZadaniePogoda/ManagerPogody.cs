using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadaniePogoda
{
    class ManagerPogody
    {
        // private - widoczność tylko w ciele klasy
        // dodatkowo dodaliśmy zabezpieczenie (const)
        // przed zmianą wartości przez nieuważnego programistę
        private const char szukanyZnak = '°';
        // public - widoczność w ciele klasy i na zewnątrz 
        public string Url = "https://www.google.com/search?q=pogoda";
        public double PodajTemperature(string nazwaMiasta)
        {
            string url = string.Format("{0}+{1}", Url, nazwaMiasta);

            string dane = new WebClient().DownloadString(url);
          
            int poz = dane.IndexOf(szukanyZnak);

            int pozStop = poz - 1;
            while (dane[pozStop] != '>')
                pozStop--;

            string wynik = dane.Substring(pozStop + 1, poz - pozStop + 1);

            return Convert.ToInt32(wynik.Substring(0, wynik.Length - 2));
        }
    }
}
