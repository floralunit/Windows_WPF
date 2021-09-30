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
using System.Windows.Shapes;

namespace Variant1
{
    /// <summary>
    /// Логика взаимодействия для UravWindow.xaml
    /// </summary>
    public partial class UravWindow : Window
    {


        public UravWindow()
        {
            
            InitializeComponent();
        }

        private void Res_button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(a_textbox.Text);
            double b = Convert.ToDouble(b_textbox.Text);
            double c = Convert.ToDouble(c_textbox.Text);
            double d = Math.Pow(b,2) - 4 * a * c;
            d_label.Content = "Дискриминант = " + d;
            if (d < 0)
            {
                res_label.Content = "Уравнение не имеет корней";
            }
            if (d == 0)
            {
                double x = -b / (2 * a);
                res_label.Content = "x = " + x;
            }
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                res_label.Content = "x1 = " + x1 + "\nx2 = " + x2;
            }

        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new MainWindow().Show();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Double width = SystemParameters.FullPrimaryScreenWidth;
            Double height = SystemParameters.FullPrimaryScreenHeight;
            this.Top = (height - this.Height) / 2;
            this.Left = (width - this.Width) / 2;
        }
    }
}
