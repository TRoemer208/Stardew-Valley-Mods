using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewModdingAPI;
using StardewValley;
using StardewValley.Monsters;

using BriarSinger_Class.Framework.Interfaces;
using BriarSinger_Class.Framework.Spells;
using BriarSinger_Class.Framework.Utilities;


namespace BriarSinger_Class.Framework.Spells.Components
{
    public class MoonBeam : Spell
    {
        //base("spellname", manacost, range)
        public MoonBeam() : base("MoonBeam", 15, 5)
        { 
        }
        public override void ApplySpell(caster, target)
        {
            target.SubtractHealth(15);
        }

        target = Utility.getClosestMonsterWithinRange where e.Cursor.Tile
            if (farmer.DistanceFromMonster > range)
            {
            return SpellCastResultType.EFFECT_FAILED
    }
    }
    

        
        
       

