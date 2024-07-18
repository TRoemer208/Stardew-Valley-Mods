using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewModdingAPI;



namespace BriarSinger_Class
{
    public class ModConfig
    {
        ///<summary>The button to cast Moonbeam.</summary>
        public SButton CastMoonBeamButton { get; set; } = SButton.Q;

        /// <summary> The button to cast the currently active non-Moonbeam spell./// </summary>
        public SButton CastSpellKey { get; set; } = SButton.G;

        public ModConfig()
        {

        }
    }
}
