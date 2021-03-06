using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фигуры_КРАСНОВ
{

    public partial class Menu1 : Form
    {
        List<Shape> shapes = new List<Shape>();
        public Color color;
        public string figurename;
        Graphics g;

        public Menu1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            g = paper.CreateGraphics();
            color = btncolor.BackColor;
            cmbboxf.SelectedIndex = 0;
            ToolTip t = new ToolTip();
            t.SetToolTip(btnSD, "Когда выберите цвет и фигуру,нажимайте на меня!!! ");
            t.SetToolTip(btnsave, "Сохраните свое творение в папке @Debug@");
            t.SetToolTip(paper, "Когда выбрали всё что нужно,кликайте мышкой!");
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            figurename = cmbboxf.SelectedItem.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Drawing(e.Graphics);

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Shape newShape = new Shape();
            newShape.ShapeName = figurename;

            newShape.PenColor = color;

            newShape.Size = Convert.ToInt32(50);
            newShape.PenWith = Figuresize.Value;
            newShape.X1 = Convert.ToInt32(e.X);
            newShape.Y1 = Convert.ToInt32(e.Y);

            shapes.Add(newShape);
            paper.Invalidate();
        }

        private void Drawing(Graphics g)
        {
            Pen pen;
            foreach (var sh in shapes)
            {
                pen = new Pen(sh.PenColor, sh.PenWith);
                switch (sh.ShapeName)
                {
                    case "Круг":
                        g.DrawEllipse(pen, sh.X1, sh.Y1, 100, 100);
                        break;
                    case "Треугольник":
                        Point[] pnt = new Point[3];

                        pnt[0].X = sh.X1;
                        pnt[0].Y = sh.Y1;

                        pnt[1].X = sh.X1 + 50;
                        pnt[1].Y = sh.Y1 + 200;

                        pnt[2].X = sh.X1 + 120;
                        pnt[2].Y = sh.Y1 + 120;
                        g.DrawPolygon(pen, pnt);
                        break;
                    case "Прямоугольник":
                        g.DrawRectangle(pen, sh.X1, sh.Y1, 175, 100);
                        break;
                    case "Линия":
                        g.DrawLine(pen, sh.X1, sh.Y1, sh.X1 + 100, sh.Y1 + 100);
                        break;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            paper.BackgroundImage = null;
            shapes.Clear();
            paper.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btncolor.BackColor = colorDialog1.Color;
            color = btncolor.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(Point.Empty, paper.Size);
            Bitmap bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            paper.DrawToBitmap(bitmap, rect);
            bitmap.Save("p1.jpeg", ImageFormat.Jpeg);

        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                paper.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            }
            openFileDialog.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }

    class Shape
    {
        public string ShapeName { get; set; }
        public Color PenColor { get; set; }
        public int Size { get; set; }
        public int PenWith { set; get; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
    }
}
