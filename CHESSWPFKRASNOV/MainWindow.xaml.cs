using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CHESSWPFKRASNOV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Figure> figures = new List<Figure>();
        bool state = false;
        Button old;
        Figure F;
        public MainWindow()
        {
            InitializeComponent();
            figures.Add(new Queen(4, 3));
            figures.Add(new Rook(1, 1));
            figures.Add(new Knight(3, 5));
            figures.Add(new Bishop(7, 6));
        }
        static T FindVisualParent<T>(UIElement element) where T : UIElement
        {
            UIElement parent = element;
            while (parent != null)
            {
                T correctlyTyped = parent as T;
                if (correctlyTyped != null)
                {
                    return correctlyTyped;
                }
                parent = VisualTreeHelper.GetParent(parent) as UIElement;
            }
            return null;
        }
        private void Move_Click(object sender, RoutedEventArgs e)
        {
            var el = FindVisualParent<Button>(sender as Button);
            int X = (int)el.GetValue(Grid.RowProperty);
            int Y = (int)el.GetValue(Grid.ColumnProperty);

            if (F == null)
            {
                F = figures.FirstOrDefault(f => f.X == X && f.Y == Y);
                old = el;
            }
            else
            {
                int colorInd = F.X + F.Y;
                bool state = false;
                switch (F.GetType().Name)
                {
                    case "Queen":
                        state = (F as Queen).Move(X, Y);
                        if (state)
                        {
                            el.Background = old.Background;
                            F = null;
                        }
                        break;
                    case "Knight":
                        state = (F as Knight).Move(X, Y);
                        if (state)
                        {
                            el.Background = old.Background;
                            F = null;
                        }
                        break;
                    case "Bishop":
                        state = (F as Bishop).Move(X, Y);
                        if (state)
                        {
                            el.Background = old.Background;
                            F = null;
                        }
                        break;
                    case "Rook":
                        state = (F as Rook).Move(X, Y);
                        if (state)
                        {
                            el.Background = old.Background;
                            F = null;
                        }
                        break;

                }
                if (state)
                {
                    var bc = new BrushConverter();
                    old.Background = colorInd % 2 == 0 ? (Brush)bc.ConvertFrom("#E8EBEF") : (Brush)bc.ConvertFrom("#7d8796");

                }


            }
        }

        private void Move_MouseDown(object sender, MouseButtonEventArgs e)
        {


        }
    }
}

