using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewValley;
using StardewModdingAPI;
using SpaceShared.APIs;

using BriarSinger_Class.Framework.Spells;
using System.Runtime.CompilerServices;

namespace BriarSinger_Class.Framework.Utilities
{
    public static class Extensions
    {

    }
    ///<summmary>Get the mod API for Generic Mod Config Menu if it's available.</summmary>
    public static IGenericModConfigMenuApi GetGenericModConfigMenuApi(this IModRegistry modRegistry, IMonitor monitor)
    {
        return modRegistry.GetApi<IGenericModConfigMenuApi>("spacechase0.GenericModConfigMenu");
    }

    public static int GetCurrentMana(this Farmer player)
    {
        return ModEntry.ManaBarApi.GetMana(player);
    }
    public static int GetMaxMana(this Farmer player)
    {
        return ModEntry.ManaBarApi.GetMaxMana(player);
    }
    public static void AddMana(this Farmer player, int amt)
    {
        ModEntry.ManaBarApi.GetMaxMana(player);
    }
         
    public static void SetMaxMana(this Farmer player, int newCap)
    {
        ModEntry.ManaBarApi.SetMaxMana(player, newCap);
    }
    public static SpellBook GetSpellBook(this Farmer player)
     {
         return ModEntry.GetSpellBook(player);
     }
    
}
