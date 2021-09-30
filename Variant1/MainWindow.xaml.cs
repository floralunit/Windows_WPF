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

namespace Variant1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SredWindow _sredwindow = new SredWindow();
        UravWindow _uravwindow = new UravWindow();
        ListWindow _listwindow = new ListWindow();
        FileWindow _filewindow = new FileWindow();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sred_button_Click(object sender, RoutedEventArgs e)
        {
            _sredwindow.Show();
            Close();
        }

        private void Urav_button_Click(object sender, RoutedEventArgs e)
        {
            _uravwindow.Show();
            Close();
        }

        private void List_button_Click(object sender, RoutedEventArgs e)
        {
            _listwindow.Show();
            Close();
        }

        private void File_button_Click(object sender, RoutedEventArgs e)
        {
            _filewindow.Show();
            Close();
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
