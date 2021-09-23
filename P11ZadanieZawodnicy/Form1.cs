using P04BibliotekaZawodnicy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11ZadanieZawodnicy
{
    public partial class Form1 : Form
    {
        ManagerZawodnikow mz;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            mz = new ManagerZawodnikow(url);
            mz.WczytajZawodnikow();
            lbDane.DataSource = mz.PodajWszystkichZawodnikow();
            lbDane.DisplayMember = "ImieNazwisko";

            

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik[] zawodnicy= mz.PodajWszystkichZawodnikow();
            string[] wiersze = new string[zawodnicy.Length];
            for (int i = 0; i < zawodnicy.Length; i++)
                wiersze[i] = zawodnicy[i].Wiersz;

            File.WriteAllLines("c:\\dane\\zawodnicy.txt", wiersze);
        }
    }
}
