using System.Windows;
using System.Windows.Controls;
namespace WPF_Controls
{
    /// <summary>
    /// Interaction logic for Assignment4.xaml
    /// </summary>
    public partial class Assignment4 : Window
    {
        private bool XSliderDragging = false;
        private bool YSliderDragging = false;
        public Assignment4()
        {
            InitializeComponent();
        }

        private void xSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender == xSlider && XSliderDragging)
            {
                var currentLeftMargin = movingLabel.Margin.Left;
                var currentTopMargin = movingLabel.Margin.Top;

                movingLabel.Margin = new Thickness(xSlider.Value,0,0,0);

                movingLabel.Content = $"* X:{(int)xSlider.Value} Y:{currentTopMargin}";
            }

        }

        private void Slider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            if (sender == xSlider)
            {
                XSliderDragging = true;
            }
            else
            {
                YSliderDragging = true;
            }


        }

        private void Slider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            if (sender == xSlider)
            {
                XSliderDragging = false;
            }
            else
            {
                YSliderDragging = false;
            }

        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        { 
            if (sender == xSlider && XSliderDragging)
            {
                
                movingLabel.Margin = new Thickness(xSlider.Value,ySlider.Value,0,0);

            }
            else
            {
                movingLabel.Margin = new Thickness(xSlider.Value,ySlider.Value,0,0);
            }
                movingLabel.Content = $"* X:{(int)xSlider.Value} Y:{(int)ySlider.Value}";

        }
    }
}
