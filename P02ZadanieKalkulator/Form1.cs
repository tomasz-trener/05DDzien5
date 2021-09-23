using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02ZadanieKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJeden_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "1";
        }

        private void btnCyfra_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender; // wypakowanie z object tego co siedzi w środku 
            // a wiemy, że w środku siedzi button
            txtWyswietlacz.Text += przycisk.Text;
        }

        private void btnCzysc_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = "";
        }

        private void btnWynik_Click(object sender, EventArgs e)
        {
            string dzialanie = txtWyswietlacz.Text;

            string[] plus = dzialanie.Split('+');
            string[] minus = dzialanie.Split('-');
            string[] mnozenie = dzialanie.Split('*');
            string[] dzielnie = dzialanie.Split('/');

            if (plus.Length == 2)
                txtWyswietlacz.Text = Convert.ToString(Convert.ToInt32(plus[0]) + Convert.ToInt32(plus[1]));
            if (minus.Length == 2)
                txtWyswietlacz.Text = Convert.ToString(Convert.ToInt32(minus[0]) - Convert.ToInt32(minus[1]));
            if (mnozenie.Length == 2)
                txtWyswietlacz.Text = Convert.ToString(Convert.ToInt32(mnozenie[0]) * Convert.ToInt32(mnozenie[1]));
            if (dzielnie.Length == 2)
                txtWyswietlacz.Text = Convert.ToString(Convert.ToDouble(dzielnie[0]) / Convert.ToDouble(dzielnie[1]));

        }
    }
}
