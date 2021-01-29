using System;
using System.Collections.Generic;

namespace poker_chips
{
    class ChipsEqualizer
    {
        public int ChipsEqualize(List<int> chips, int expected) {
            int count = 0;
            int diff;
            int chipsLength = chips.Count;
            int average = (int)Average(chips);

            for (int j = 0; j < chipsLength; j++)
            {
                for (int i = 0; i < chipsLength; i++)
                {
                    if (i < chipsLength - 1)
                    {
                        diff = chips[i + 1] - chips[i];
                        if (Math.Abs(diff) > 1)
                        {
                            chips[i] = chips[i] + diff / 2;
                            chips[i + 1] = chips[i + 1] - diff / 2;
                            count += Math.Abs(diff / 2);
                        }
                    }
                    else if (i == chipsLength - 1)
                    {
                        diff = chips[0] - chips[chipsLength - 1];
                        if (Math.Abs(diff) > 1)
                        {
                            chips[chipsLength - 1] = chips[chipsLength - 1] + diff / 2;
                            chips[0] = chips[0] - diff / 2;
                            count += Math.Abs(diff / 2);
                        }
                    }
                }
            }
            Console.WriteLine($"chip moves = {count} expected {expected}");
            return count;
        }

        public int Sum(List<int> list) {
            int sum = 0;
            foreach (int elem in list) {
                sum += elem;
            }
            return sum;
        }

        public double Average(List<int> list) {
            double result = 1.0 * Sum(list) / list.Count;
            return result;
}
    }
}
