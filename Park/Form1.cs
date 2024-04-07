using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            poziceBalonkuY = 302;

            BTN_Vypustit.Enabled = CB_Umisteni.Checked;
            savedAngle = angle = 0;
            AktualizovatPoziciSlunce(angle);
        }

        PointF aktualniPozice;

        float poziceBalonkuY;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(Properties.Resources.pozadi_modra, 0, 0, 640, 320);

            graphics.DrawImage(Properties.Resources.slunce_poledne, aktualniPozice.X, aktualniPozice.Y, 100, 73);

            graphics.DrawImage(Properties.Resources.pozadi_alfa_mraky, 0, 0, 640, 320);

            graphics.DrawImage(Properties.Resources.park, 0, PB_Park.Height - 277, 640, 277);

            if(!CB_Otevreno.Checked)
            {
                graphics.DrawImage(Properties.Resources.plot_brana, 203, 227, 200, 73);
            }

            graphics.DrawImage(Properties.Resources.fontana, PB_Park.Width/2-220/2, 350, 220, 95);

            graphics.DrawImage(Properties.Resources.stromy, 10, 190, 110, 176);

            if (CB_Umisteni.Checked)
            {
                graphics.DrawImage(Properties.Resources.balonky, 130, poziceBalonkuY, 100, 161);
            }

            graphics.DrawImage(Properties.Resources.kamen, 160, 460, 24, 12);
        }

        private void CB_Umisteni_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Vypustit.Enabled = CB_Umisteni.Checked;
            poziceBalonkuY = 302;
            PB_Park.Refresh();
        }

        private void CB_Otevreno_CheckedChanged(object sender, EventArgs e)
        {
            PB_Park.Refresh();
        }

        private void BTN_Vypustit_Click(object sender, EventArgs e)
        {
            if (!CB_Umisteni.Checked) return;
            BalonekAnim.Start();
            BTN_Vypustit.Enabled = false;
            CB_Umisteni.Enabled = false;
        }

        private void BalonekAnim_Tick(object sender, EventArgs e)
        {
            poziceBalonkuY -= 10;
            if (poziceBalonkuY < -200)
            {
                CB_Umisteni.Checked = false;

                CB_Umisteni.Enabled = true;
                BalonekAnim.Stop();
            }
            PB_Park.Refresh();
        }

        private void BTN_Putovani_Click(object sender, EventArgs e)
        {
            angle = savedAngle;
            PutovaniAnim.Start();
            BTN_Putovani.Enabled = false;
            RB_Odpoledne.Enabled = RB_Rano.Enabled = RB_Vecer.Enabled = false;
        }


        float angle = 0;
        float savedAngle = 0;

        private void PutovaniAnim_Tick(object sender, EventArgs e)
        {
            angle += 5;
            angle %= 360;

            if(angle >= 100 && angle <= 180)
            {
                angle = savedAngle;
                BTN_Putovani.Enabled = true;
                RB_Odpoledne.Enabled = RB_Rano.Enabled = RB_Vecer.Enabled = true;
                PutovaniAnim.Stop();
            }

            AktualizovatPoziciSlunce(angle);
        }

        private void RB_ChangeEvent(object sender, EventArgs e)
        {
            PutovaniAnim.Stop();
            RadioButton cb = (RadioButton)sender;

            savedAngle = int.Parse(cb.Tag.ToString());

            AktualizovatPoziciSlunce(savedAngle);
        }


        float radius = 230;
        void AktualizovatPoziciSlunce(float NewAngle)
        {
            aktualniPozice.X = 250 + (float)Math.Sin(Math.PI * NewAngle / 180) * radius;
            aktualniPozice.Y = 250 - (float)Math.Cos(Math.PI * NewAngle / 180) * radius;

            PB_Park.Refresh();
        }
    }
}
