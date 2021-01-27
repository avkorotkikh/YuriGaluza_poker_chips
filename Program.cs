using System;
using System.Collections;
using System.Collections.Generic;

namespace poker_chips
{
    class Program
    {
        private static void Main(string[] args)
        {
            ChipsEqualizer equalizer = new ChipsEqualizer();

            equalizer.ChipsEqualize(new List<int>{ 1, 5, 9, 10, 5 });
            equalizer.ChipsEqualize(new List<int> { 1, 2, 3 });
            equalizer.ChipsEqualize(new List<int> { 0, 1, 1, 1, 1, 1, 1, 1, 1, 2 });
            
        }
    }
}

