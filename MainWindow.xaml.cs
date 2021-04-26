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

namespace QuadraticEquations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bstart_Click(object sender, RoutedEventArgs e)
        {
            TBx1.Text = null;
            TBx2.Text = null;
            try
            {
                double
                    a = Convert.ToDouble(TBa.Text),
                    b = Convert.ToDouble(TBb.Text),
                    c = Convert.ToDouble(TBc.Text),
                    discriminant = Math.Pow(b, 2) - (4 * a * c);


                if (a == 0)
                {
                    if (b != 0 && c != 0) TBx1.Text = Convert.ToString(-c / b);
                    else if (c == 0 && b != 0) TBx1.Text = Convert.ToString(-b);
                    else if (b == 0 && c == 0 || b == 0 && c != 0) TBx1.Text = "Нет уравнения";
                }
                else if (b == 0)
                {
                    if (c == 0) TBx1.Text = "0";
                    if (-c / a > 0)
                    {
                        TBx1.Text = Convert.ToString(Math.Round(Math.Sqrt(-c / a), 5));
                        TBx2.Text = "-" + Convert.ToString(Math.Round(Math.Sqrt(-c / a),5));
                    }
                    else TBx1.Text = "Нет корней";
                }
                else if (c == 0)
                {
                    double x = -b / a;
                    TBx1.Text = Convert.ToString(x);
                    TBx2.Text = "0";
                }
                else if (discriminant < 0)
                {
                    double
                        x = (-b / (2 * a)),
                        i = (Math.Sqrt(-discriminant) / (2 * a));

                    TBx1.Text = x.ToString() + "+" + Math.Round(i, 2).ToString() + "i";
                    TBx2.Text = x.ToString() + "-" + Math.Round(i, 2).ToString() + "i";
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    TBx1.Text = Convert.ToString(x);
                }
                else
                {
                    double
                        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a),
                        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    TBx1.Text = Convert.ToString(Math.Round(x1, 5));
                    TBx2.Text = Convert.ToString(Math.Round(x2, 5));
                }
            }
            catch
            {
                MessageBox.Show("Синтаксическая ошибка");
            }
        }
    }
}
