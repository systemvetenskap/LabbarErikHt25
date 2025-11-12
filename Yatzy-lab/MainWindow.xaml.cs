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

        public MainWindow()
        {
            InitializeComponent();
            txtRollsLeft.Text = _rollsLeft.ToString();

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

            // sätt en hakparentes = skapa en array
            int[] dices = new int[5];
            // här har  vi en array of integers med fem fack

            // vi måste räkna ner antalet slag som återstår
            // reglerna säger max tre kast. Sedan ska användaren
            // satsa på en kategori, ettor till sexor
            _rollsLeft--;
            txtRollsLeft.Text = _rollsLeft.ToString();


            // vi vill kasta tärningarna i en loop

            // första sorten loop = foreach
            //int counter = 0;

            //foreach (int dice in dices)
            //{
            //    dices[counter] = _random.Next(1, 7);
            //    counter++;
            //}

            // Den andra loop-sorten är en for

            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = _random.Next(1, 7);
            }






            // Slumpa värden
            // dice1 = _random.Next(); // från 0 till 2,147,483,647
            //dices[0] = _random.Next(1, 7); // från 1 till 6
            //dices[1] = _random.Next(1, 7); // från 1 till 6
            //dices[2] = _random.Next(1, 7); // från 1 till 6
            //dices[3] = _random.Next(1, 7); // från 1 till 6
            //dices[4] = _random.Next(1, 7); // från 1 till 6
            ////dice1 = _random.Next(6) + 1;// från 1 till 6

            //dice5 = 3;

            // jag vill säga att tärning nummer 2 ska få värdet 5
            // 0  1 2 3 4
            // [][][][][]
            //int diceValue = _random.Next(1,6);
            //dices[diceValue - 1] = diceValue;


            // visa i gränssnittet vad vi fått för resultat
            diceOne.Text = dices[0].ToString();
            diceTwo.Text = dices[1].ToString();
            diceThree.Text = dices[2].ToString();
            diceFour.Text = dices[3].ToString();
            diceFive.Text = dices[4].ToString();

            // mål
            // summera totalvärdet av alla tärningar
            // = kategori chansen
            int total = 0;
            // vi loopar.

            foreach (int dice in dices)
            {
                total += dice;
            }

            // Uppdrag!
            // vi vill ju kunna spara på ett vist tärningsslag
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