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

namespace P07ZadanieKraje
{
    public partial class Form1 : Form
    {
        const string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
        ManagerZawodnikow mz;
        public Form1()
        {
            InitializeComponent();
            mz = new ManagerZawodnikow(url);     
            cbKraje.DataSource= mz.PodajKraje();
            
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            lbDane.DataSource= mz.Filtruj(cbKraje.Text);
            lbDane.DisplayMember = "ImieNazwisko";
        }


    }
}
