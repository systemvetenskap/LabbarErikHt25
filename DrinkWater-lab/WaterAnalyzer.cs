using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkWater_lab
{
    internal class WaterAnalyzer
    {
        public int CountAtoms(string formula, char atom)
        {
            int count = 0;
            // H2O
            // O
            return count;
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
    }
}
