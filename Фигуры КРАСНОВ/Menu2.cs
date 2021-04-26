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
    public partial class Menu2 : Form
    {
        public Menu1 form1;
        public Menu2(Menu1 f1)
        {
            InitializeComponent();
            form1 = f1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncansel_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            form1.color = comboBox2.SelectedItem.ToString();
            form1.figurename = comboBox1.SelectedItem.ToString();
            if(form1.color != null)
            {
                Graphics g = form1.panel1.CreateGraphics();
                Pen pen = new Pen(System.Drawing.ColorTranslator.FromHtml(form1.color));
                g.DrawEllipse(pen, 10, 10, 20, 20);
            }
            if (form1.color != null)
            {
                Graphics f = form1.panel1.CreateGraphics();
                Pen pen = new Pen(System.Drawing.ColorTranslator.FromHtml(form1.color));
                f.DrawLine(pen, 75, 100, 100, 75);
                Close();
                Dispose();
            }
            if (form1.color != null)
            {
                Graphics h = form1.panel1.CreateGraphics();
                Pen pen = new Pen(System.Drawing.ColorTranslator.FromHtml(form1.color));
                h.DrawRectangle(pen, 75, 100, 100, 75);
                Close();
                Dispose();
            }
        }

        private void Menu2_Load(object sender, EventArgs e)
        {

        }
    }
}
