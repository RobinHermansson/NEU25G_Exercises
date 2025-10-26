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

namespace WPF_Controls
{
    /// <summary>
    /// Interaction logic for Assignment1.xaml
    /// </summary>
    public partial class Assignment1 : Window
    {

        private int _timesClicked = 0;
        public Assignment1()
        {
            InitializeComponent();
        }

        private void ClickerButton_Click(object sender, RoutedEventArgs e)
        {
            ClickerButton.Content = $"Clicked {_timesClicked++} times!";

        }
    }
}
