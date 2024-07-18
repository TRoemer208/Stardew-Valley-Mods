using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriarSinger_Class.Framework.Spells
{
    public class SpellBookData
    {
        public Farmer Player { get; }

        public SpellBookData(Farmer player)
        {
            this.Player = player;
        }
        public SavedSpellBook ReadSpellBook(ModEntry modEntry)
        {
            SavedSpellBook spellbook = new SavedSpellBook();
            return spellbook;
        }
    }
   
}
