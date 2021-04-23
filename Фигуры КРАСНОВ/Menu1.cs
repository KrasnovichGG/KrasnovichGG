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
            Menu2 menu2 = new Menu2(this);
            menu2.Show();
            if (menu2.IsDisposed)
            {
                Graphics g = panel1.CreateGraphics();
                Pen pen = new Pen(System.Drawing.ColorTranslator.FromHtml(color));
                g.DrawEllipse(pen, 5, 5, 10, 10);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
