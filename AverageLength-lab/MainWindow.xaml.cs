using System.Windows;

namespace AverageLength_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SentenceAnalyzer _analyzer = new SentenceAnalyzer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private double CalculateAverageWordLength(string word)
        {
            return 0;
        }


        private void OnValidateClick(object sender, RoutedEventArgs e)
        {
            string message = _analyzer.GetFeedback("Idag är det julfrukost");

            if (_analyzer.IsAboveLimit)
            {

            }
        }
    }
}