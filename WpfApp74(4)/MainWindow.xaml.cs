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

namespace WpfApp74
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
                double A = Convert.ToDouble(TbNumberA.Text);
                int N = Convert.ToInt32(TbNumberB.Text);
                double r = 0;
                for (int i = 0; i <= N; i++)
                {
                    if (k == -1)
                    {
                        double el = Math.Pow(A, i);
                        if (i % 2 == 1)
                        {
                            el = -el;
                            ListBoxData.Items.Add(el.ToString());
                        }
                        r += el;
                    }
                }
                if (k == -1)
                {
                    TextBlockAnswer.Text = $"Ответ:\n{r}";
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
