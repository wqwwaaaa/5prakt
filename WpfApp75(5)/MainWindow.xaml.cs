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

namespace WpfApp75
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = -1;
                double xn, yn;
                double sum = 0;
                double xn_1 = 1;
                double yn_1 = 1;
                double n = Convert.ToDouble(TbNumberA.Text);
                
                if (k == -1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        xn = xn_1 * 0.3;
                        yn = xn_1 + yn_1;
                        double an = xn / (1 + Math.Abs(yn));
                        ListBoxData.Items.Add(an.ToString("F5"));
                        sum += an;
                        xn_1 = xn;
                        yn_1 = yn;

                    }
                }
                if (k == -1)
                {
                    TextBlockAnswer.Text = $"Ответ:\n{sum}";
                }
                else
                {
                    TextBlockAnswer.Text = "Неверные значения";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
