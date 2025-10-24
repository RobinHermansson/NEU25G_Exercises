using System.Windows;

namespace XAML
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

        private void Assignment1Button_Click(object sender, RoutedEventArgs e)
        {

            Assignment1 assignment1 = new Assignment1();
            assignment1.Show();

        }
        private void Assignment2Button_Click(object sender, RoutedEventArgs e)
        {

            Assignment2 assignment2 = new Assignment2();
            assignment2.Show();

        }
    }
}
