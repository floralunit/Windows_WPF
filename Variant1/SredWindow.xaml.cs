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
            double sum = 0;
            int lineCount = num_textbox.LineCount;

            List<string> lines = new List<string>();
            for (int i = 0; i<lineCount;i++)
            {
                lines.Add(num_textbox.GetLineText(i));
            }
            List<double> numbers = lines.Select(double.Parse).ToList();
            for (int j = 0; j < numbers.Count; j++)
            {
                sum += numbers[j];
            }
                double res = sum / numbers.Count;
            res_label.Content = "Среднее арифметическое равно: " + res;
        }

        private void string_button_Click(object sender, RoutedEventArgs e)
        {
            num_textbox.Text = num_textbox.Text + "\n";
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new MainWindow().Show();
        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            num_textbox.Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Double width = SystemParameters.FullPrimaryScreenWidth;
            Double height = SystemParameters.FullPrimaryScreenHeight;
            this.Top = (height - this.Height) / 2;
            this.Left = (width - this.Width) / 2;
        }
    }
}
