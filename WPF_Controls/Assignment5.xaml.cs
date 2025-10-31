using System.Windows;
using System.Windows.Navigation;


namespace WPF_Controls

{
    /// <summary>
    /// Interaction logic for Assignment5.xaml
    /// </summary>
    public partial class Assignment5 : Window
    {

        private int yPos = 0;
        private int xPos = 0;
        public Assignment5()
        {
            InitializeComponent();
        }

        private void labelMoverSlider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {

        }

        private void labelMoverSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {

        }

        private void labelMoverSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            if ((bool)xLock.IsChecked && (bool)yLock.IsChecked)
            {
                return;
            }
            else if ((bool)!xLock.IsChecked)
            {
                xPos = (int)labelMoverSlider.Value;
                movingLabel.Margin = new Thickness(xPos, yPos, 0, 0);
            }
            else if ((bool)!yLock.IsChecked)
            {
                yPos = (int)labelMoverSlider.Value;
                movingLabel.Margin = new Thickness(xPos, yPos, 0, 0);
            }

        }
    }
}
