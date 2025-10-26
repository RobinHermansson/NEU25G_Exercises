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
    /// Interaction logic for Assignment2.xaml
    /// </summary>
    public partial class Assignment2 : Window
    {
        private int initialValue = 0;
        public Assignment2()
        {
            InitializeComponent();
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            var currentValueCounter = int.Parse(CounterLabel.Content.ToString());

            if (currentValueCounter < 9)
            {
                currentValueCounter++;
                CounterLabel.Content = currentValueCounter;
            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            var currentValueCounter = int.Parse(CounterLabel.Content.ToString());

            if (currentValueCounter > 0)
            {
                currentValueCounter--;
                CounterLabel.Content = currentValueCounter;
            }

        }
    }
}
