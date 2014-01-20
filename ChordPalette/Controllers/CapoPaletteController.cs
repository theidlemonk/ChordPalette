using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapoChordSheet;
using ChordPalette.Models;

namespace ChordPalette.Controllers
{
    public class CapoPaletteController : Controller
    {

        private IChordSheet _chordSheet;

        public CapoPaletteController(IChordSheet _chordSheet)
        {
            this._chordSheet = _chordSheet;
        }

        public CapoPaletteController()
        {
        }

        public ActionResult CapoHome()
        {
            IChordSheet _chordSheet = new ChordSheet();
            List<CapoStrings> capoStrings = new List<CapoStrings>();
            var newSound = _chordSheet.GetStandardSound(0);

            foreach (var CapoedSound in newSound )
            {
                capoStrings.Add(new CapoStrings { Sound = CapoedSound.Sound });
            }



            return View(capoStrings);
        }

    }
}
