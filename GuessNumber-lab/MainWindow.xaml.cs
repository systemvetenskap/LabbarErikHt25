using System.Windows;
using Accessibility;

namespace GuessNumber_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // vi skapar en slumpgenerator på detta ställe för att kunna
        // använda den flera gånger utan att behöva bygga en ny "enarmad bandit"
        
        Random _slumpgenerator;
        int _secretNumber;
        int _count = 0;

        // konstruktorn körs en enda gång == när programmet startar
        public MainWindow()
        {
            InitializeComponent();
            _slumpgenerator = new Random();
            btnGuess.IsEnabled = false;
        }

        private void OnNewClick(object sender, RoutedEventArgs e)
        {
             _secretNumber = _slumpgenerator.Next(100) + 1;
            btnNew.Content = _secretNumber.ToString();
            btnGuess.IsEnabled = true;
        }

        private void OnGuessClick(object sender, RoutedEventArgs e)
        {
            if (txtGuess.Text == "")
            {
                MessageBox.Show("Du ska mata in ett värde");
                return;
            }

            if (_secretNumber == 0)
            {
                MessageBox.Show("Du måste slumpa ett nytt tal");
                return;
            }

            // räkna antalet  gissningar
            _count++;


            // läser in vilket tal användaren har gissat på
            int guess = int.Parse(txtGuess.Text);


            // ta reda på om användaren gissat rätt eller fel
            if (guess == _secretNumber)
            {
                MessageBox.Show($"Grattis, {guess} var rätt men du behöve {_count} försök");
            }
            else
            {
                MessageBox.Show("Det blev fel");
            }
            // om det var fel, hur långt ifrån var jag?
           
            // presentera antalet för användaren

        }

     
    }
}