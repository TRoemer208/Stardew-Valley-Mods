using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpaceCore;
using SpaceCore.Content;
using StardewValley;
using StardewModdingAPI;
using StardewValley.Extensions;
using StardewModdingAPI.Events;
using SpaceShared.APIs;

using BriarSinger_Class.Framework.Spells;
using BriarSinger_Class.Framework.Utilities;
using BriarSinger_Class.Framework.Spells.Components;


namespace BriarSinger_Class
{
    public class Events
    {


        //   DailyTracker dailyTracker;
        ModEntry modEntryInstance;

        public Events(ModEntry modEntry) //,DailyTracker dailyTracker)
        {
            modEntryInstance = modEntry;

            //this.dailyTracker = dailyTracker;
        }

        ///<summary>Event called when the game launches to load content packs.</summary>
        public void OnGameLaunched(object sender, GameLaunchedEventArgs e)
        {
            //Arguments for the generic mod config menu
            var configMenu = modEntryInstance.Helper.ModRegistry.GetGenericModConfigMenuApi(modEntryInstance.Monitor);

            if (configMenu != null)
            {
                configMenu.Register(
                    mod: modEntryInstance.ModManifest,
                    reset: () => modEntryInstance.Config = new ModConfig(),
                    save: () => modEntryInstance.Helper.WriteConfig(modEntryInstance.Config)
                    );

                configMenu.AddNumberOption(
                    mod: modEntryInstance.ModManifest,
                    name: () => modEntryInstance.Helper.Translation.Get("config.position_x.name"),
                    tooltip: () => modEntryInstance.Helper.Translation.Get("config.position_x.tooltip"),
                    getValue: () => modEntryInstance.Config.Position.X,
                    setValue: value => modEntryInstance.Config.Position = new(value, modEntryInstance.Config.Position.Y)
                );

                configMenu.AddNumberOption(
                    mod: modEntryInstance.ModManifest,
                    name: () => modEntryInstance.Helper.Translation.Get("config.position_y.name"),
                    tooltip: () => modEntryInstance.Helper.Translation.Get("config.position_y.tooltip"),
                    getValue: () => modEntryInstance.Config.Position.Y,
                    setValue: value => modEntryInstance.Config.Position = new(modEntryInstance.Config.Position.X, value)
                );
                configMenu.AddKeybind(
                     mod: modEntryInstance.ModManifest,
                     name: () => modEntryInstance.Helper.Translation.Get("config.cast_moonbeam.name"),
                     tooltip: () => modEntryInstance.Helper.Translation.Get("config.cast_moonbeam.tooltip"),
                     getValue: () => modEntryInstance.Config.CastMoonBeamButton,
                     setValue: value => modEntryInstance.Config.CastMoonBeamButton = value
                 );
            }

            //hook mana bar
            {
                var manaBar = modEntryInstance.Helper.ModRegistry.GetApi<IManaBarApi>("spacechase0.ManaBar");

                if (manaBar == null)
                {
                    modEntryInstance.Monitor.Log("No Mana Bar API", LogLevel.Error);
                    return;
                }
                ModEntry.ManaBarApi = manaBar;
            }

            //hook Content Patcher
            {
                var api = modEntryInstance.Helper.ModRegistry.GetApi<ContentPatcher.IContentPatcherAPI>("Pathoschild.ContentPatcher");
                ModEntry.ContentPatcherApi = api;
            }
        }
        ///<summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        public void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (Game1.activeClickableMenu != null)
                return;

            Farmer farmer = Game1.player;

            if (Context.IsPlayerFree)
            {
                var input = modEntryInstance.Helper.Input;

                if (e.Button == modEntryInstance.Config.CastMoonBeamButton)
                {
                    SpellCastResult result = MoonBeam.Cast(farmer target);
                }
                else if (e.Button == modEntryInstance.Config.CastSpellKey)
                {
                    Spell activeSpell = SpellBook.ActiveSpell;
                    SpellCastResult result = activeSpell.Cast(farmer, tileTarget);
                }
            }
        }



    }
} 
