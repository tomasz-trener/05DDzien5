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

namespace P03KontrolkaListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            lbDane.Items.Clear();
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            ManagerZawodnikow mz = new ManagerZawodnikow(url);

            mz.WczytajZawodnikow();
            Zawodnik[] zawodnicy = mz.Filtruj(txtKraj.Text);

            foreach (var z in zawodnicy)
            {
                lbDane.Items.Add(z.Imie + " " + z.Nazwisko);
            }
        }



    }
}
