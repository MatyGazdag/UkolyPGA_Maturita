using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakDěláZvířátko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nahoda = new Random();
        }

        public Random nahoda;
        public int vylosovaneCislo;

        public Image[] zvirata =
        {
            Properties.Resources.cow,
            Properties.Resources.dog,
            Properties.Resources.pig
        };

        private void BTN_NovaHra_Click(object sender, EventArgs e)
        {
            vylosovaneCislo = nahoda.Next(0, zvirata.Length);
            PB_Obrazky.BackgroundImage = zvirata[vylosovaneCislo];
            PB_Obrazky.BackColor = Color.White;

            BTN_Buu.Visible = BTN_Chro.Visible = BTN_Haf.Visible = true;
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            Button klik = (Button)sender;
            int index = int.Parse((string)klik.Tag);

            if(index == vylosovaneCislo)
            {
                Spravne();
            }else
            {
                Spatne();
            }
        }

        void Spravne()
        {
            PB_Obrazky.BackColor = Color.Green;
        }

        void Spatne()
        {
            PB_Obrazky.BackColor = Color.Red;
        }
    }
}
