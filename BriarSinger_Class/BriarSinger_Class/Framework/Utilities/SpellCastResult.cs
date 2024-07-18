using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriarSinger_Class.Framework.Utilities
{
    public class SpellCastResult
    {
        SpellCastResultType spellCastResultType;

        public SpellCastResult()
        {
            spellCastResultType = SpellCastResultType.SUCCESS;
        }
        public SpellCastResult(SpellCastResultType spellCastResultType)
        {
            this.spellCastResultType = spellCastResultType;
        }
        public void SetSpellCastResultType(SpellCastResultType spellCastResultType)
        {
            this.spellCastResultType = spellCastResultType;
        }
        public SpellCastResultType GetSpellCastResultType()

        {
            return this.spellCastResultType;
        }

        //Returns true if this spell cast result represents a failed cast, false otherwise
        public bool IsFail()
        {
            return spellCastResultType != SpellCastResultType.SUCCESS;
        }

        //Returns true if this spell cast result should consume mana
        public bool IsConsume()
        {
            return spellCastResultType == SpellCastResultType.SUCCESS;
        }
    }

        public enum SpellCastResultType
        {
            SUCCESS,
            NOT_ENOUGH_MANA,
            EFFECT_FAILED
        }
    
}
