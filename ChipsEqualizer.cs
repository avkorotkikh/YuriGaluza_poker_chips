using System;
using System.Collections.Generic;
using System.Text;

namespace poker_chips
{
    class ChipsEqualizer
    {
        public int ChipsEqualize(List<int> chips,int expected) {
            int count = 0;
            
            for (int j = 0; j < chips.Count; j++)
            {
                for (int i = 1; i < chips.Count; i++) 
                {
                    int diff = chips[i] - chips[i - 1];
                    if (diff != 0 && Math.Abs(diff) > 1)
                    {
                        chips[i] = chips[i] - diff / 2;
                        chips[i - 1] = chips[i - 1] + diff / 2;
                        count += Math.Abs(diff / 2);
                    }
                    else if (i == chips.Count - 1) {
                        int diffEnd = chips[0] - chips[chips.Count - 1];
                        chips[0] = chips[0] - diffEnd / 2;
                        chips[i] = chips[i] + diffEnd / 2;
                        count += Math.Abs(diffEnd / 2);
                    }
                }
            }
            Console.WriteLine($"chip moves = {count} expected {expected}");
            return count;
        }
    }
}
