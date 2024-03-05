using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kámen__nůžky__papír_
{
    public class Hrac
    {
        public Hrac(PictureBox pictureBox, TextBox textbox) 
        {
            this.pictureBox = pictureBox;
            this.textBox = textbox;
        }

        PictureBox pictureBox;
        TextBox textBox;

        public int pocetBodu = 0;

        public void Vyhra()
        {
            pocetBodu++;
            Form1.celkovyPocetBodu++;
            textBox.Text = "Počet bodů: " + pocetBodu;
        }

        public void ZobrazitObrazek(int index)
        {
            pictureBox.BackgroundImage = Form1.obrazky[index];
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            nahoda = new Random();
            celkovyPocetBodu = 0;

            hrac1 = new Hrac(PB_Hrac1, TXB_Hrac1);
            hrac2 = new Hrac(PB_Hrac2, TXB_Hrac2);

            PB_Hrac2.BackgroundImage = null;
            PB_Hrac1.BackgroundImage = null;
        }

        Hrac hrac1;
        Hrac hrac2;

        public Random nahoda;
        public static int celkovyPocetBodu;

        public static Image[] obrazky =
        {
            Properties.Resources.kamen,
            Properties.Resources.nuzky,
            Properties.Resources.papir
        };

        private void BTN_Hra_Click(object sender, EventArgs e)
        {
            PB_Hrac2.BackgroundImage = null;
            PB_Hrac1.BackgroundImage = null;

            int Hrac1Cislo = nahoda.Next(0, obrazky.Length);
            int Hrac2Cislo = nahoda.Next(0, obrazky.Length);

            hrac1.ZobrazitObrazek(Hrac1Cislo);
            hrac2.ZobrazitObrazek(Hrac2Cislo);

            LogikaHry(Hrac1Cislo, Hrac2Cislo);
        }

        void LogikaHry(int Hrac1Cislo, int Hrac2Cislo)
        {
            if(Hrac1Cislo == Hrac2Cislo)
            {
                //Remiza
            }else if((Hrac1Cislo + 1) % 3 == Hrac2Cislo)
            {
                hrac1.Vyhra();
            }else
            {
                hrac2.Vyhra();
            }

            /*if(Hrac1Cislo == 0 && Hrac2Cislo == 2) //(Hrac1)Kamen < (Hrac2)Papir
            {
                hrac2.Vyhra();
            }else if (Hrac1Cislo == 1 && Hrac2Cislo == 0) //(Hrac1)Nuzky > (Hrac2)Kamen
            {
                hrac2.Vyhra();
            }else if(Hrac1Cislo == 2 && Hrac2Cislo == 1) //(Hrac1)Papir > (Hrac2)Nuzky
            {
                hrac2.Vyhra();
            }

            else if (Hrac2Cislo == 0 && Hrac1Cislo == 2)
            {
                hrac1.Vyhra();
            }
            else if (Hrac2Cislo == 1 && Hrac1Cislo == 0)
            {
                hrac1.Vyhra();
            }
            else if (Hrac2Cislo == 2 && Hrac1Cislo == 1)
            {
                hrac1.Vyhra();
            }

            else
            {
                //Remíza
            }*/
        }
    }
}
