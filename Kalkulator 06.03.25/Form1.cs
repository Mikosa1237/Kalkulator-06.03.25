using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_06._03._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wyswietlacz.Text = "0";
        }
        string total;
        int num1;
        int num2;
        string opcja;
        int wynik;

        private void klikPrzycisku(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if (wyswietlacz.Text == "0")
                wyswietlacz.Text = string.Empty;

            wyswietlacz.Text += clickedValue;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            opcja = "+";
            num1 = int.Parse(wyswietlacz.Text);

            wyswietlacz.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            opcja = "-";
            num1 = int.Parse(wyswietlacz.Text);

            wyswietlacz.Clear();
        }

        private void btnMnoz_Click(object sender, EventArgs e)
        {
            opcja = "*";
            num1 = int.Parse(wyswietlacz.Text);

            wyswietlacz.Clear();
        }

        private void btnDziel_Click(object sender, EventArgs e)
        {
            opcja = "/";
            num1 = int.Parse(wyswietlacz.Text);

            wyswietlacz.Clear();
        }

        private void btnWynik_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(wyswietlacz.Text);

            if (opcja == ("+"))
                wynik = num1 + num2;

            if (opcja == ("-"))
                wynik = num1 - num2;

            if (opcja == ("*"))
                wynik = num1 * num2;

            if (opcja == ("/"))
                wynik = num1 / num2;

            wyswietlacz.Text = wynik+"";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            wyswietlacz.Clear();
            wynik = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
