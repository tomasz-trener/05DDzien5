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
            string url = "c:\\dane\\zawodnicy.txt";

            mz = new ManagerZawodnikow(url);
            mz.WczytajZawodnikow();
            lbDane.DataSource = mz.PodajWszystkichZawodnikow();
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik[] zawodnicy= mz.PodajWszystkichZawodnikow();
            string[] wiersze = new string[zawodnicy.Length+1];
            wiersze[0] = "id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga";
            for (int i = 1; i < zawodnicy.Length+1; i++)
                wiersze[i] = zawodnicy[i-1].Wiersz;

            File.WriteAllLines("c:\\dane\\zawodnicy.txt", wiersze);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;
            mz.Usun(z);
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            txtWaga.Text = z.Waga.ToString();
            txtWzrost.Text = z.Wzrost.ToString();
            txtDataUr.Text = z.DataUrodzenia.ToString();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.Waga = Convert.ToInt32(txtWaga.Text);
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            z.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);

            mz.Aktualizuj((Zawodnik[])lbDane.DataSource);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Zawodnik z = new Zawodnik(txtImie.Text, txtNazwisko.Text);
            z.Kraj = txtKraj.Text;
            z.Waga = Convert.ToInt32(txtWaga.Text);
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            z.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);
            mz.Dodaj(z);
        }
    }
}
