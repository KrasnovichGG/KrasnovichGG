using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фигуры_КРАСНОВ
{

    public partial class Menu1 : Form
    {
        public string color;
        public string figurename;
        public Menu1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            if (cmbcolor1.SelectedIndex <= -1 || cmbboxf.SelectedIndex <= -1)
                return;

            color = cmbcolor1.SelectedItem.ToString();
            figurename = cmbboxf.SelectedItem.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen;
            switch (figurename)
            {
                case "Круг":
                    pen = new Pen(ColorTranslator.FromHtml(color));
                   g.DrawEllipse(pen, e.X, e.Y, 100, 100);
                   break;
                case "Треугольник":
                    Point[] pnt = new Point[3];

                    pnt[0].X = e.X;
                    pnt[0].Y = e.Y;

                    pnt[1].X = 150;
                    pnt[1].Y = 200;

                    pnt[2].X = 50;
                    pnt[2].Y = 120;
                    pen = new Pen(ColorTranslator.FromHtml(color));
                    g.DrawPolygon(pen,pnt);
                    break;
                case "Прямоугольник":
                    pen = new Pen(ColorTranslator.FromHtml(color));
                    g.DrawRectangle(pen, e.X, e.Y, 100, 100);
                    break;
                case "Линия":
                    pen = new Pen(ColorTranslator.FromHtml(color));
                    g.DrawLine(pen, e.X, e.Y, 100, 100);
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(this.BackColor);
        }

        private void cmbcolor1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbboxf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
