using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewValley;

namespace BriarSinger_Class.Framework.Spells
{
    public interface IEntity
    {
        object entity { get; }

        GameLocation GetGameLocation();

        Vector2 GetPosition();

        Rectangle GetBoundingBox();

        int GetHorizontalMovement();

        int GetVerticalMovement();
    }
}
