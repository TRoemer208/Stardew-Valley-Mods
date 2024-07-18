using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewValley;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using SpaceCore;
using StardewValley.Buffs;
using BriarSinger_Class.Framework.Utilities;
using StardewValley.Monsters;
using BriarSinger_Class.Framework.Spells;

namespace BriarSinger_Class.Framework.Spells
{
    public abstract class Spell
    {
        public string Name { get; set; }
        public int ManaCost { get; set; }
        public int Range { get; set; }
        protected Spell(string name, int manaCost, int range)
        {
            Name = name;
            ManaCost = manaCost;
            Range = range;
        }
        public void Cast(Farmer farmer, target);
        {
        farmer.SubtractMana(ManaCost);
            ApplySpell(Farmer, target);
        }
    
public interface SpellHelper
{ SpellCastResult Cast(IEntity caster, GameLocation gameLocation, bool consume);
}
}





/*
  {
    public class Spell : SpellHelper
    {
        ModEntry modEntry;

      public Spell(ModEntry modEntry)
        {
            this.modEntry = modEntry;
           }
        public SpellCastResult Cast(IEntity caster, GameLocation gameLocation, bool consume)
        {
            float manaValue = Mana();

            if (((Farmer)caster.entity).GetCurrentMana() < manaValue)
                return new SpellCastResult(SpellCastResultType.NOT_ENOUGH_MANA);

            if (result.IsSuccess() && caster.entity is Farmer)
            {
                Farmer player = (Farmer)caster.entity;

                /* if (Game1.player.HasCustomProfession(Skill.Skill.Seer))
                 {
                     int manaCostPercentage = 75;
                    {
                         ((Farmer)caster.entity).AddMana(-manaValueInt);
                     }
                 }
                 else
                
                {
                    ((Farmer)caster.entity).AddMana(-manaValue);
                }

            }

            //  SpellCastResult result = IsSuccess //figure this out later

            //  return result;
            return new SpellCastResult(SpellCastResultType.SUCCESS);
        }
        public int Mana()
        {
            int cost = 0;
            int multiplier = 1;

            cost *= multiplier;

            return cost;
        }
    }
}
*/