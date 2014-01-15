using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordRepository
{
    public class Chords
    {
        public Dictionary<string, int> GetCapoChordSpectrum()
        {
            return new Dictionary<string, int>()
            {
                {"A♭", 1},
                {"A", 2},
                {"B♭", 3},
                {"B", 4},
                {"C", 5},
                {"D♭", 6},
                {"D", 7},
                {"E♭", 8},
                {"E", 9},
                {"F", 10},
                {"F#", 11},
                {"G", 12}
            };
        }
    }
}