using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    enum StavSemaforu
    {
        Cervena,
        Zluta,
        Zelena
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int OffAlpha = 150, OnAlpha = 255;

        int[] alpha = {150, 150, 150 };

        StavSemaforu aktualniStavS = StavSemaforu.Cervena;

        private void PPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;

            int velikost = 100;
            float horizontalCenter = (PPanel.Width / 2) - (velikost / 2);
            //float offsetY = 

            graphic.FillRectangle(new SolidBrush(Color.Black), 5, 5, PPanel.Width - 10, PPanel.Height - 10);
            graphic.FillEllipse(new SolidBrush(Color.FromArgb(alpha[0], Color.Red)), horizontalCenter, 25, velikost, velikost);
            graphic.FillEllipse(new SolidBrush(Color.FromArgb(alpha[1], Color.Yellow)), horizontalCenter, 150, velikost, velikost);
            graphic.FillEllipse(new SolidBrush(Color.FromArgb(alpha[2], Color.Green)), horizontalCenter, 275, velikost, velikost);
        }

        private void Animace_Tick(object sender, EventArgs e)
        {
            switch(aktualniStavS)
            {
                case StavSemaforu.Cervena:
                    alpha[2] = OffAlpha;
                    alpha[0] = OnAlpha;
                    aktualniStavS = StavSemaforu.Zluta;
                    Animace.Interval = 5000;
                    break;
                case StavSemaforu.Zluta:
                    alpha[0] = OffAlpha;
                    alpha[1] = OnAlpha;
                    aktualniStavS = StavSemaforu.Zelena;
                    Animace.Interval = 2000;
                    break;
                case StavSemaforu.Zelena:
                    alpha[1] = OffAlpha;
                    alpha[2] = OnAlpha;
                    aktualniStavS = StavSemaforu.Cervena;
                    Animace.Interval = 5000;
                    break;
            }
            PPanel.Refresh();
        }

        private void BTN_AnimaceSwitch_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string type = (btn.Tag.ToString());
            if(type == "Start")
            {
                Animace.Start();
            }
            else
            {
                Animace.Stop();
            }
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int index = int.Parse(btn.Tag.ToString());

            if (alpha[index] == OnAlpha)
            {
                alpha[index] = OffAlpha;
            }
            else
            {
                alpha[index] = OnAlpha;
            }

            PPanel.Refresh();
        }
    }
}
