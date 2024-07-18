using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewValley;

namespace BriarSinger_Class
{
  /*  public class HarpSword
    {
        public StardewValley.Tools.GenericTool();
    }
  */
    //left click is sword swing
    //right click is StarShot cast
    //shift right click is select spell
    //g is cast spell
}


/// add this stuff to the ModEntry when ready
/// if (e.NameWithoutLocale.IsEquivalentTo("Data/Weapons"))
/// {
/// e.Edit(asset =>
/// {
/// IAssetDataForDictionary<string, WeaponData> editor = asset.asDictionary<string, WeaponData>();
/// 
/// editor.Data[HARPSWORD_WEAPON_ID] = new WeaponData {
/// Name = "HarpSword",
/// DisplayName = "HarpSword",
/// Description = "Your old harp, now a versatile weapon and spellcasting focus.",
/// Type = 3,
/// SpriteIndex = //don't know yet,
/// Texture = "TileSheets/weapons", //I think
/// MinDamage = x, //fill this in later
/// MaxDamage = y, //fill this in later
/// Speed = 0,
/// CanBeLostOnDeath = false,
/// AreaofEffect = 1,
/// CritChance = 0.02f,
/// CritMultiplier = 3.0f,
/// Precision = 10
/// };
/// });
/// }
/// 

/// Add to the weapon sprite sheet.
/// if (e.NameWithoutLocale.IsEquivalentTo("TileSheets/weapons"))
/// {
/// e.Edit(asset =>
/// {
/// IRawTextureData sourceImage = Helper.ModContent.Load<IRawTextureData>("assets/harpsword.png");
/// IAssetDataForImage editor = asset.AsImage();
/// editor.PatchImage(sourceImage, sourceArea: new Rectangle(16,0,32,16), targetArea: new Rectangle(96, 128, 32, 16));
/// });
/// }
/// 
