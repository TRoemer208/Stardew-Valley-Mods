using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewModdingAPI.Events;

namespace BriarSinger_Class.Framework.Utilities
{
    public interface IActiveEffect
    {
        //Update tick events.
        void Update(UpdateTickedEventArgs args);
        void OneSecondUpdate(OneSecondUpdateTickedEventArgs e);

        //Draw effect to screen if needed.
        void Draw(SpriteBatch spriteBatch);
    }
    
}
