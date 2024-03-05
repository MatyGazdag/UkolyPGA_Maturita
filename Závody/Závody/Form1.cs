using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Závody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nahoda = new Random();
        }

        public float Hrac1_PoziceX = 0;
        public float Hrac2_PoziceX = 0;

        Random nahoda;

        public int strana = 30;

        private void PPole_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            
            graph.DrawRectangle(Pens.Black, 5, 5, PPole.Width - 10, PPole.Height - 10);
            graph.DrawLine(Pens.Black, 5, 40, PPole.Width - 5, 40);

            int pocet = 20;
            float offset = (PPole.Width - 10) / pocet;

            for(int i = 0; i < pocet; i++)
            {
                graph.DrawLine(Pens.Black, 5 + offset * i, 5, 5 + offset * i, PPole.Height - 5);
            }

            graph.DrawImage(Properties.Resources.player1, 10 + offset * Hrac1_PoziceX, 6, strana, strana);
            graph.DrawImage(Properties.Resources.player2, 10 + offset * Hrac2_PoziceX, 6 + offset, strana, strana);
        }

        private void BTN_Hraj_Click(object sender, EventArgs e)
        {
            int posunHrac1 = nahoda.Next(1, 4);
            int posunHrac2 = nahoda.Next(1, 4);

            TXB_Hrac1.Text = "Padlo: " + posunHrac1;
            TXB_Hrac2.Text = "Padlo: " + posunHrac2;

            if (Hrac1_PoziceX + posunHrac1 > 19)
            {
                Hrac1_PoziceX = 19;
            }else
            {
                Hrac1_PoziceX += posunHrac1;
            }

            if (Hrac2_PoziceX + posunHrac2 > 19)
            {
                Hrac2_PoziceX = 19;
            }else
            {
                Hrac2_PoziceX += posunHrac2;
            }

            if(Hrac1_PoziceX == 19 && Hrac2_PoziceX == 19)
            {
                Remiza();
            }else if(Hrac1_PoziceX == 19)
            {
                Vyhral(true);
            }else if(Hrac2_PoziceX == 19)
            {
                Vyhral(false);
            }

            PPole.Refresh();
        }

        void Vyhral(bool hrac1)
        {
            PB_Vyherce.Visible = true;
            LBL_StavHry.Visible = true;
            LBL_StavHry.Text = "Vítěz: ";
            if (hrac1)
            {
                PB_Vyherce.Image = Properties.Resources.player1;
            }
            else
            {
                PB_Vyherce.Image = Properties.Resources.player2;
            }

            BTN_Hraj.Enabled = BTN_Hraj.Visible = false;
            BTN_Reset.Visible = BTN_Reset.Enabled = true;
        }

        void Remiza()
        {
            LBL_StavHry.Visible = true;
            LBL_StavHry.Text = "Remíza";

            BTN_Hraj.Enabled = BTN_Hraj.Visible = false;
            BTN_Reset.Visible = BTN_Reset.Enabled = true;
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            Hrac2_PoziceX = Hrac1_PoziceX = 0;
            PB_Vyherce.Visible = LBL_StavHry.Visible = false;

            BTN_Reset.Visible = BTN_Reset.Enabled = false;
            BTN_Hraj.Enabled = BTN_Hraj.Visible = true;

            TXB_Hrac1.Text = "";
            TXB_Hrac2.Text = "";

            PPole.Refresh();
        }
    }
}
