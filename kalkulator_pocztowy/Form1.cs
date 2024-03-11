using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_pocztowy
{
    public partial class Form1 : Form
    {
        private int cena;
        private int ilosc;
        private string typ;
        public Form1()
        {
            InitializeComponent();
        }
        public enum Listy
        {
            A = 5,
            B = 10,
            C = 15,
            D = 20
        }
        public enum Paczki
        {
            A = 10,
            B = 15,
            C = 20, 
            D = 25
        }

        private void obliczListbtn_Click(object sender, EventArgs e)
        {
            szczegolyPods.Text = "Rodzaj przesyłki: List \n";
            if(Convert.ToString(rozmiarListuBox.SelectedItem) == "A - 5 zł")
            {
                cena = (int)Listy.A * Convert.ToInt32(iloscListu.Value);
                cenaValue.Text = Convert.ToString(cena + " zł");
                
            }
            if (Convert.ToString(rozmiarListuBox.SelectedItem) == "B - 10 zł")
            {
                cena = (int)Listy.B * Convert.ToInt32(iloscListu.Value);
                cenaValue.Text = Convert.ToString(cena + " zł");
            }
            if (Convert.ToString(rozmiarListuBox.SelectedItem) == "C - 15 zł")
            {
                cena = (int)Listy.C * Convert.ToInt32(iloscListu.Value);
                cenaValue.Text = Convert.ToString(cena + " zł");
            }
            if (Convert.ToString(rozmiarListuBox.SelectedItem) == "D - 20 zł")
            {
                cena = (int)Listy.D * Convert.ToInt32(iloscListu.Value);
                cenaValue.Text = Convert.ToString(cena + " zł");
            }

            if (smsList.Checked == true)
            {
                typ = "SMS";
            }else if (emailList.Checked == true)
            {
                typ = "Email";
            }
            checkListlbl.Text = "Typ korespodencji: " + typ + "\n";

            if(odbiorListuCheck.Checked == true)
            {
                checkListlbl.Text += "Potwierdzenie odbioru: tak \n";
            }
            else
            {
                checkListlbl.Text += "Potwierdzenie odbioru: nie \n";
            }

            string tresc = trescListuBox.Text;
            if (!string.IsNullOrEmpty(trescListuBox.Text))
            {
                szczegolyPods.Text = "Treść: \n" + tresc;
            }
        }

        private void obliczPaczkabtn_Click(object sender, EventArgs e)
        {
            szczegolyPods.Text = "Rodzaj przesyłki: Paczka \n";
            if (Convert.ToString(rozmiarPaczkiBox.SelectedItem) == "A - 10 zł")
            {
                cena = (int)Paczki.A * Convert.ToInt32(iloscPaczek.Value);
                cenaValue.Text = Convert.ToString(cena + " zł");
            }
            if (Convert.ToString(rozmiarPaczkiBox.SelectedItem) == "B - 15 zł")
            {
                cena = (int)Paczki.B * Convert.ToInt32(iloscPaczek.Value);
                cenaValue.Text = Convert.ToString(cena + " zł");
            }
            if (Convert.ToString(rozmiarPaczkiBox.SelectedItem) == "C - 20 zł")
            {
                cena = (int)Paczki.C * Convert.ToInt32(iloscPaczek.Value);
                cenaValue.Text = Convert.ToString(cena + " zł");
            }
            if (Convert.ToString(rozmiarPaczkiBox.SelectedItem) == "D - 25 zł")
            {
                cena = (int)Paczki.D * Convert.ToInt32(iloscPaczek.Value);
                cenaValue.Text = Convert.ToString(cena + " zł");
            }

            if (smsPaczka.Checked == true)
            {
                typ = "SMS";
            }
            else if (emailPaczka.Checked == true)
            {
                typ = "Email";
            }
            checkListlbl.Text = "Typ korespodencji: " + typ + "\n";

            if (odbiorPaczkiCheck.Checked == true)
            {
                checkListlbl.Text += "Potwierdzenie odbioru: tak \n";
            }
            else
            {
                checkListlbl.Text += "Potwierdzenie odbioru: nie \n";
            }

            string tresc = trescPaczkiBox.Text;
            if (!string.IsNullOrEmpty(trescPaczkiBox.Text))
            {
                szczegolyPods.Text = "Treść: \n" + tresc;
            }
        }
    }
}
