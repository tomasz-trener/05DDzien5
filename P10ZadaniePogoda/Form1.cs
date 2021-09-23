using P10ZadaniePogoda.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10ZadaniePogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPogoda_Click(object sender, EventArgs e)
        {
            ManagerPogody mp = new ManagerPogody();
            double temp= mp.PodajTemperature(txtNazwaMiasta.Text);
            lblWynik.Text = Convert.ToString(temp);

            pcbObrazek.Visible = true;

            if(temp > 10)
                pcbObrazek.Image = Resources.sun;
            else if (temp > 0)
                pcbObrazek.Image = Resources.cloud;
            else
                pcbObrazek.Image = Resources.snow;

            lbHistoria.Items.Add(txtNazwaMiasta.Text + " " + temp);

        }
    }
}
