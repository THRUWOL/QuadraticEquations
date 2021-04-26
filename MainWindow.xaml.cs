using System;
using System.Windows;

namespace QuadraticEquations
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bstart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TBx1.Text = null; TBx2.Text = TBx1.Text;
                if (Convert.ToDouble(TBa.Text) == 0)
                {
                    if (Convert.ToDouble(TBb.Text) != 0 && Convert.ToDouble(TBc.Text) != 0) TBx1.Text = Convert.ToString(-(Convert.ToDouble(TBc.Text)) / Convert.ToDouble(TBb.Text));
                    else if (Convert.ToDouble(TBc.Text) == 0 && Convert.ToDouble(TBb.Text) != 0) TBx1.Text = Convert.ToString(-(Convert.ToDouble(TBb.Text)));
                    else if (Convert.ToDouble(TBb.Text) == 0 && Convert.ToDouble(TBc.Text) == 0 || Convert.ToDouble(TBb.Text) == 0 && Convert.ToDouble(TBc.Text) != 0) TBx1.Text = "Нет уравнения";
                }
                else if (Convert.ToDouble(TBb.Text) == 0)
                {
                    if (Convert.ToDouble(TBc.Text) == 0) TBx1.Text = "0";
                    if (-(Convert.ToDouble(TBc.Text)) / Convert.ToDouble(TBa.Text) > 0)
                    {
                        TBx1.Text = Convert.ToString(Math.Round(Math.Sqrt(-(Convert.ToDouble(TBc.Text)) / Convert.ToDouble(TBa.Text)), 5));
                        TBx2.Text = "-" + Convert.ToString(Math.Round(Math.Sqrt(-(Convert.ToDouble(TBc.Text)) / Convert.ToDouble(TBa.Text)), 5));
                    }
                    else TBx1.Text = "Нет корней";
                }
                else if (Convert.ToDouble(TBc.Text) == 0)
                {
                    TBx1.Text = Convert.ToString(-(Convert.ToDouble(TBb.Text)) / Convert.ToDouble(TBa.Text));
                    TBx2.Text = "0";
                }
                else if (Math.Pow(Convert.ToDouble(TBb.Text), 2) - (4 * Convert.ToDouble(TBa.Text) * Convert.ToDouble(TBc.Text)) < 0)
                {
                    TBx1.Text = (-(Convert.ToDouble(TBb.Text)) / (2 * Convert.ToDouble(TBa.Text))).ToString() + "+" + Math.Round((Math.Sqrt(-(Math.Pow(Convert.ToDouble(TBb.Text), 2) - (4 * Convert.ToDouble(TBa.Text) * Convert.ToDouble(TBc.Text)))) / (2 * Convert.ToDouble(TBa.Text))), 2).ToString() + "i";
                    TBx2.Text = (-(Convert.ToDouble(TBb.Text)) / (2 * Convert.ToDouble(TBa.Text))).ToString() + "-" + Math.Round((Math.Sqrt(-(Math.Pow(Convert.ToDouble(TBb.Text), 2) - (4 * Convert.ToDouble(TBa.Text) * Convert.ToDouble(TBc.Text)))) / (2 * Convert.ToDouble(TBa.Text))), 2).ToString() + "i";
                }
                else if (Math.Pow(Convert.ToDouble(TBb.Text), 2) - (4 * Convert.ToDouble(TBa.Text) * Convert.ToDouble(TBc.Text)) == 0) TBx1.Text = Convert.ToString(-Convert.ToDouble(TBb.Text) / (2 * Convert.ToDouble(TBa.Text)));
                else
                {
                    TBx1.Text = Convert.ToString(Math.Round((-(Convert.ToDouble(TBb.Text)) + Math.Sqrt(Math.Pow(Convert.ToDouble(TBb.Text), 2) - (4 * Convert.ToDouble(TBa.Text) * Convert.ToDouble(TBc.Text)))) / (2 * Convert.ToDouble(TBa.Text)), 5));
                    TBx2.Text = Convert.ToString(Math.Round((-(Convert.ToDouble(TBb.Text)) - Math.Sqrt(Math.Pow(Convert.ToDouble(TBb.Text), 2) - (4 * Convert.ToDouble(TBa.Text) * Convert.ToDouble(TBc.Text)))) / (2 * Convert.ToDouble(TBa.Text)), 5));
                }
            }
            catch
            {
                MessageBox.Show("Синтаксическая ошибка");
            }
        }
    }
}