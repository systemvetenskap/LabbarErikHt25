using System.Windows;

namespace Yatzy_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // "⚀⚁⚂⚃⚄⚅"
        }


        private void OnOkClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnClearClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnRollClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnOnesClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ettor klickade");
        }

        private void OnTwosClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tvåor klickade");
        }

        private void OnThreesClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Treor klickade");
        }

        private void OnFoursClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fyror klickade");
        }

        private void OnFivesClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Femmor klickade");
        }

        private void OnSixesClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sexor klickade");
        }
    }
}