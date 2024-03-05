using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planetky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            center = new PointF((P_SolarniSystem.Width / 2),(P_SolarniSystem.Height / 2));
        }

        private void AnimaceSolSystem_Tick(object sender, EventArgs e)
        {
            planetAngle += 5;
            planetAngle %= 360;
            orbitAngle += 7;
            orbitAngle %= 360;  
            P_SolarniSystem.Refresh();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            AnimaceSolSystem.Start();
        }

        SizeF sunSize = new SizeF(30, 30);
        SizeF planetSize = new SizeF(20, 20);
        SizeF orbitSize = new SizeF(8, 8);
        PointF center;

        float radius = 70;
        float orbitRadius = 20;

        float planetAngle = 50;
        float orbitAngle = 160;

        const float AngleToRadians = (float)((Math.PI * 2) / 360);

        private void P_SolarniSystem_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(new SolidBrush(Color.Yellow), new RectangleF(new PointF(center.X - (sunSize.Width / 2), center.Y - (sunSize.Height / 2)), sunSize));

            PointF planetPos = new PointF(center.X + (float)Math.Sin(planetAngle * AngleToRadians) * radius, center.Y + (float)Math.Cos(planetAngle * AngleToRadians) * radius);
            g.FillEllipse(new SolidBrush(Color.Blue), new RectangleF(new PointF(planetPos.X - planetSize.Width / 2, planetPos.Y - planetSize.Height / 2), planetSize));

            PointF orbitPos = new PointF((planetPos.X - orbitSize.Width / 2) + (float)Math.Sin(orbitAngle * AngleToRadians) * orbitRadius, (planetPos.Y - orbitSize.Height / 2) + (float)Math.Cos(orbitAngle * AngleToRadians) * orbitRadius);
            g.FillEllipse(new SolidBrush(Color.Red), new RectangleF(orbitPos, orbitSize));

        }
    }
}
