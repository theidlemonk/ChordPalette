using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapoChordSheet
{
    public class ChordSheet : IChordSheet
    {
        public List<Chords> GetStandardSound(int CapoFret)
        {
            List<Chords> chords = new List<Chords>();
            chords.Add(new Chords() { Sound = "A" });
            chords.Add(new Chords() { Sound = "B" });
            chords.Add(new Chords() { Sound = "C" });
            chords.Add(new Chords() { Sound = "D" });
            chords.Add(new Chords() { Sound = "E" });
            chords.Add(new Chords() { Sound = "F" });
            chords.Add(new Chords() { Sound = "G" });

            return chords;

        }
    }
}