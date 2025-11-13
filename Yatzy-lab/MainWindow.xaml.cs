using System.Windows;

namespace Yatzy_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random _random = new();
        int _rollsLeft = 3;

        // sätt en hakparentes = skapa en array
        int[] _dices;

        int _total = 0;

        public MainWindow()
        {
            InitializeComponent();
            txtRollsLeft.Text = _rollsLeft.ToString();
            string level = "normal";

            if (level == "maxi")
            {
                _dices = new int[7];
            }
            else
            {
                _dices = new int[5];

            }
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
            // Spelet har fem tärningar
            // men varje tärning har sex sidor
            //int dice1, dice2, dice3, dice4, dice5;


            // här har  vi en array of integers med fem fack

            // vi måste räkna ner antalet slag som återstår
            // reglerna säger max tre kast. Sedan ska användaren
            // satsa på en kategori, ettor till sexor
            _rollsLeft--;
            txtRollsLeft.Text = _rollsLeft.ToString();

            bool[] savedDices = { 
                (bool)chkDiceOne.IsChecked, 
                (bool)chkDiceTwo.IsChecked ,
                (bool)chkDiceThree.IsChecked,
                (bool)chkDiceFour.IsChecked,
                (bool)chkDiceFive.IsChecked
               };
            for (int index = 0; index < _dices.Length; index++)
            {

                // Är tärningen sparad?
                // är = if-sats
                bool throwDice = !savedDices[index];
                if (throwDice)
                {
                    _dices[index] = _random.Next(1, 7);
                }
            }

            // visa i gränssnittet vad vi fått för resultat
            diceOne.Text = _dices[0].ToString();
            diceTwo.Text = _dices[1].ToString();
            diceThree.Text = _dices[2].ToString();
            diceFour.Text = _dices[3].ToString();
            diceFive.Text = _dices[4].ToString();
        }

        private void OnOnesClick(object sender, RoutedEventArgs e)
        {
            // mål
            // summera totalvärdet av alla tärningar
            // där vi bara kikar på ettor

            foreach (int dice in _dices)
            {
                if (dice == 1)
                {
                    _total += dice;
                }
            }

            // int[] dice = { Int32.Parse(diceOne.Text), Int32.Parse(diceTwo.Text), Int32.Parse(diceThree.Text), Int32.Parse(diceFour.Text), Int32.Parse(diceFive.Text) };

            int ones = 0;
            for (int i = 0; i < _dices.Length; i++)
            {
                int dice = _dices[i];
                if (dice == 1)
                {
                    ones += 1;
                }
            }
            txtOnes.Text = ones.ToString();

        }

        private void OnTwosClick(object sender, RoutedEventArgs e)
        {

            foreach (int dice in _dices)
            {
                if (dice == 2)
                {
                    _total += dice;
                }
            }
            txtTwos.Text = _total.ToString();
        }

        private void OnThreesClick(object sender, RoutedEventArgs e)
        {
            foreach (int dice in _dices)
            {
                if (dice == 3)
                {
                    _total += dice;
                }
            }
            txtTwos.Text = _total.ToString();
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