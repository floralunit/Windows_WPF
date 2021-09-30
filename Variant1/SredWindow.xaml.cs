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
    /// Логика взаимодействия для SredWindow.xaml
    /// </summary>
    public partial class SredWindow : Window
    {
        public SredWindow()
        {
            InitializeComponent();
        }

        private void Res_button_Click(object sender, RoutedEventArgs e)
        {
            double db = 0;
            int n = num_textbox.LineCount;
            for (int i = 0; i<n;i++)
            {
                db += Convert.ToDouble(num_textbox.Text[i]);
            }
            double res = db / n;
            res_label.Content = "Среднее арифметическое равно: " + res;
        }
    }
}
