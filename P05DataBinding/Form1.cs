using P04BibliotekaZawodnicy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            ManagerZawodnikow mz = new ManagerZawodnikow(url);

            mz.WczytajZawodnikow();
            Zawodnik[] zawodnicy= mz.Filtruj("POL");
            lbDane.DataSource = zawodnicy;
            // polaczenie nasych danych z kontrolką lbDane
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            // to zdarznie wywola sie gdy ktoś zmieni zaznaczenie elementu w listobx 

            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            MessageBox.Show(zaznaczony.Kraj + " " + zaznaczony.Nazwisko);


        }
    }
}
