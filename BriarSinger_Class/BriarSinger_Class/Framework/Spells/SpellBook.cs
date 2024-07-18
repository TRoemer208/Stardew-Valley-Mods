using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriarSinger_Class.Framework.Spells
{
    public class SpellBook
    {
        public Farmer Player => this.Data.Player;
        private readonly SpellBookData Data;

        public Spell MoonBeam { get; set; }
        public Spell ActiveSpell { get; set; }

        //List of known spells in a player's spell book.
        private List<SpellBookData> spells;

        //currrently active spell
        private SpellBookData activeSpell;

        public SpellBook(Farmer player)
        {
            this.Data = new SpellBookData(player);

        }

        private SavedSpellBook ReadSpellBook(ModEntry modEntry)
        {
            return GetData().ReadSpellBook(modEntry);
        }

        public SpellBookData GetData()
            { return this.Data; }
    }
}
