using System;
using System.Collections.Generic;

namespace poker_chips
{
    class Program
    {
        private static void Main(string[] args)
        {
            ChipsEqualizer equalizer = new ChipsEqualizer();      

            equalizer.ChipsEqualize(new List<int> { 1, 5, 9, 10, 5 }, 12);
            equalizer.ChipsEqualize(new List<int> { 1, 2, 3 }, 1);
            equalizer.ChipsEqualize(new List<int> { 0, 1, 1, 1, 1, 1, 1, 1, 1, 2 }, 1);
            equalizer.ChipsEqualize(new List<int> { 6, 2, 4, 10, 3 }, 8);
            equalizer.ChipsEqualize(new List<int> { 8, 10, 2, 5, 5 }, 7);
            equalizer.ChipsEqualize(new List<int> { 0, 3, 10, 6, 1 }, 13);
            equalizer.ChipsEqualize(new List<int> {2, 7, 4, 2, 4, 10, 5, 7, 2, 7 }, 16);
            equalizer.ChipsEqualize(new List<int> {0, 10, 0, 8, 3, 10, 7, 0, 9, 3 }, 24);
            equalizer.ChipsEqualize(new List<int> {13, 8, 28, 21, 30, 6, 13, 27, 23, 1 }, 66);
            equalizer.ChipsEqualize(new List<int> {3, 2, 1, 2 }, 2);           
        }
    }
}

