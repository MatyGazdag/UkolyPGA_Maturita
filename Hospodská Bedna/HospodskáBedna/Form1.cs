using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospodskáBedna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            aktualniKredit = 0;
            celkemVyhozeno = 0;

            CB_CenaRoztoceni.SelectedIndex = 0;

            valce = new PictureBox[3] { PB_Valec1, PB_Valec2, PB_Valec3 };
            nahoda = new Random();
        }

        public int aktualniKredit
        {
            get
            {
                return _aktualniKredit;
            }

            set
            {
                _aktualniKredit = value;
                TXB_AktualniKredit.Text = _aktualniKredit.ToString() + ".- Kč";
            }
        }

        public int celkemVyhozeno
        {
            get
            {
                return _celkemVyhozeno;
            }

            set
            {
                _celkemVyhozeno = value;
                TXB_CelkemVyhozeno.Text = _celkemVyhozeno.ToString() + ".- Kč";
            }
        }
        public int cenaRoztoceni => int.Parse(CB_CenaRoztoceni.Text);

        private int _aktualniKredit;
        private int _celkemVyhozeno;

        public Image[] obrazky =
        {
            Properties.Resources.jablko,
            Properties.Resources.hamburger,
            Properties.Resources.pomeranc,
            Properties.Resources.citron,
            Properties.Resources.pizza,
            Properties.Resources.hvezda,
        };

        public PictureBox[] valce;
        public Random nahoda;

        private void BTN_Vloz_Click(object sender, EventArgs e)
        {
            int castka = (int)NUM_hotovost.Value;

            aktualniKredit += castka;
        }

        private void BTN_Roztoc_Click(object sender, EventArgs e)
        {
            if (aktualniKredit < cenaRoztoceni) { MessageBox.Show("Nemáte dostatek kreditů", "Chyba"); return; };

            aktualniKredit -= cenaRoztoceni;

            BTN_Roztoc.Enabled = false;

            pocetToceni = nahoda.Next(10, 15);
            AnimaceUpdate.Start();
        }

        private void BTN_Vybrat_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Celková bilance: {aktualniKredit-celkemVyhozeno}","Statisiky");
            aktualniKredit = celkemVyhozeno = 0;
        }

        int pocetToceni, pocet;

        private void AnimaceUpdate_Tick(object sender, EventArgs e)
        {
            if(pocet < pocetToceni)
            {
                foreach (var pb in valce)
                {
                    int index = nahoda.Next(0, obrazky.Length);
                    pb.BackgroundImage = obrazky[index];
                    pb.Tag = index.ToString();
                }
            }else
            {
                AnimaceUpdate.Stop();
                pocet = 0;
                BTN_Roztoc.Enabled = true;
                Tocky();
            }
            pocet++;
        }

        void Tocky()
        {
            int nasobek = 0;

            int castka = 0;

            Dictionary<int, int> pociteDuplicitni = new Dictionary<int, int>();

            for (int i = 0; i < valce.Length; i++)
            {
                int index = int.Parse((string)valce[i].Tag);

                if (pociteDuplicitni.ContainsKey(index))
                {
                    pociteDuplicitni[index]++;
                }else
                {
                    pociteDuplicitni[index] = 1;
                }
            }

            for(int i = 0; i < obrazky.Length; i++)
            {
                if (!pociteDuplicitni.ContainsKey(i)) continue;

                if(i == 5) //Hvězdy
                {
                    if (pociteDuplicitni[i] == 3)
                    {
                        nasobek = 5;
                        castka = cenaRoztoceni * nasobek;
                        MessageBox.Show($"Gratulujeme, odnášíte si výhru {castka}.- Kč", "");
                        break;
                    }else if(pociteDuplicitni[i] == 2)
                    {
                        nasobek = 3;
                        castka = cenaRoztoceni * nasobek;
                        MessageBox.Show($"Vyhráli jste {castka}.- Kč", "Výhra");
                        break;
                    }
                }

                if (pociteDuplicitni[i] == 3)
                {
                    nasobek = 3;
                    castka = cenaRoztoceni * nasobek;
                    MessageBox.Show($"Vyhráli jste {castka}.- Kč", "Výhra");
                    break;
                }else if(pociteDuplicitni[i] == 2)
                {
                    nasobek = 2;
                    castka = cenaRoztoceni * nasobek;
                    MessageBox.Show($"Vyhráli jste {castka}.- Kč", "Malá výhra");
                    break;
                }
            }

            aktualniKredit += castka;
            if(castka == 0)
            {
                celkemVyhozeno += cenaRoztoceni;
            }
        }
    }
}
