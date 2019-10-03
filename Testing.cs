using System;

namespace NumberGenerator
{
    public class Testing
    {
        private IRandom random;
        private int[] frequencies;
        private int numberIntervals;
        private int amountNumbers;
        private int expectedFrequency;

        public Testing(IRandom random, int numberIntervals=20, int amountNumbers=10000)
        {
            this.random = random;
            this.numberIntervals = numberIntervals;
            this.amountNumbers = amountNumbers;

            frequencies = new int[numberIntervals];
            expectedFrequency = amountNumbers / numberIntervals;
        }

        public double ChiSquared()
        {
            FilArrayOfFrequencies();
            double chi = 0;

            for (int i = 0; i < numberIntervals; i++)
                chi += Math.Pow(frequencies[i] - expectedFrequency, 2) / expectedFrequency;

            return chi;
        }

        private void FilArrayOfFrequencies()
        {
            double[] generatedNumbers = GenerateArrayOfNumbers();

            for (int i = 0; i < amountNumbers; i++)
            {
                int hitInterval = CalculateHitInterval(generatedNumbers[i]);
                frequencies[hitInterval]++;
            }
        }

        private double[] GenerateArrayOfNumbers()
        {
            var array = new double[amountNumbers];
            for (int i = 0; i < amountNumbers; i++)
                array[i] = random.GenerateNumber();

            return array;
        }

        private int CalculateHitInterval(double num)
            => (int)(numberIntervals * num);
    }
}
