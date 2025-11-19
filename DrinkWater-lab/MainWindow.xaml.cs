using System.Windows;

namespace DrinkWater_lab
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

        private int CalculateHAtoms(string molekyl)
        {
            int numberOfH = 0;
            char kontrollChar;
            int molekylLength = molekyl.Length;
            {
                for (int i = 0; i < molekylLength; i++)
                {
                    kontrollChar = molekyl[i];
                    if (kontrollChar == 'H' || kontrollChar == 'h')
                    {
                        numberOfH = numberOfH + 1;
                    }
                }
                return numberOfH;
            }
        }


        private void OnButtonCalculateClick(object sender, RoutedEventArgs e)
        {
            string formula = "H221222O";
            formula = "H2O";
            int count = CountOccurences(formula, 'H');

            if (ContainsValue(formula, 'C'))
            {
                MessageBox.Show("Varning, den här drycken är giftig");
            }

        }


        private int CountOccurences(string senctence, char letter)
        {
            int count = 0;
            foreach (char sign in senctence)
            {
                if (sign == letter)
                {
                    count++;
                }
            }
            return count;
        }

        private bool ContainsValue(string formula, char atom)
        {
            foreach (char letter in formula)
            {
                if (char.ToUpper(letter) == char.ToUpper(atom))
                {
                    return true;
                }
            }
            return false;
        }
    }
}