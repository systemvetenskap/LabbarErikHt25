using System.Windows;

namespace Temperatures_lab
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

        private double GetMaxTemperature(double[] temperatures)
        {
            double maxTemp = double.MinValue;

            foreach (double temperature in temperatures)
            {
                // är temperaturen jag nu ser högst?
                if (temperature > maxTemp)
                {
                    // om sant. Ja den är just nu högst
                    maxTemp = temperature;
                }
            }

            return maxTemp;
        }

        private double GetMinTemperature(double[] temperatures)
        {
            double minTemp = double.MaxValue;

            foreach (double temperature in temperatures)
            {
                // är temperaturen jag nu ser högst?
                if (temperature < minTemp)
                {
                    // om sant. Ja den är just nu högst
                    minTemp = temperature;
                }
            }
            // returnera svaret
            // alltid samma datatyp som utdatatypen i metodhuvudet
            return minTemp;
        }
        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            // Lägg till en temperatur för varje dag
            double maxTemp, minTemp;
            double[] temperatures = { 1.2, 2.0, -0.3, -1.1, 0.0, 1.8, 3.3 };

            // hämtar högsta temperaturen från vår nyskapade metod
            maxTemp = GetMaxTemperature(temperatures);
            minTemp = GetMinTemperature(temperatures);

            temperatures = new double[]{ 4.5, 5.2, 3.8, 6.0, 5.4, 7.1, 6.3};
            maxTemp = GetMaxTemperature(temperatures);
        }

        private void OnCalcClick(object sender, RoutedEventArgs e)
        {
            // Beräkna max, min och medelvärde
            // mån, tis, ons, to , fre, lör, sön

            // testdata
            double[] temperatures = { -4.5, -5.2, -3.8, -6.0, -5.4, -7.1, -3.8 };
            double minTemp = GetMinTemperature(temperatures);
            double maxTemp = GetMaxTemperature(temperatures);
            double meanTemp = 0; 

            // förväntat resultat
            // Medel: 5.47 °C  Högsta: 7.1 °C  Lägsta: 3.8 °C 
            // 12
            // 4.5

            // Erik hade otur när han fyllde i sina yatzytärningar
            // lägsta värdet?
            


            // medelvärde
            // = summan av antalet värden / antal värden
            double sum = 0;
            foreach (double temperature in temperatures)
            {
                sum += temperature;
            }
            int[] dices = { 2, 5, 6, 3, 2, 2 };
            int diceSum = 0;
            foreach (int dice in dices)
            {
                diceSum += dice;
            }
            
            meanTemp = sum / 7.0;
            meanTemp = (double)diceSum / dices.Length;
        }

    }
}