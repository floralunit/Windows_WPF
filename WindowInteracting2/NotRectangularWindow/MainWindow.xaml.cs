using System.Windows;
using System.Windows.Input;

namespace NotRectangularWindow
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
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем текущее приложение.
            Application.Current.Shutdown();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Для перетаскивания окна за любую область.
            DragMove();
        }
    }
}

