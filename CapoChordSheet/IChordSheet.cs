using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapoChordSheet
{
    public interface IChordSheet
    {
         List<Chords> GetStandardSound(int CapoFret);
    }
}