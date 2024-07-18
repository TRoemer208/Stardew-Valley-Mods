using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using SpaceCore;
using SpaceShared.APIs;
using SpaceCore.Events;
using StardewValley;
using StardewModdingAPI;

using BriarSinger_Class.Framework.Spells;

namespace BriarSinger_Class
{
    public class ModEntry : Mod
    {
        public static IModHelper helper;
        public ModConfig Config;

        //Calling APIs and related content
        public static IManaBarApi ManaBarApi;
        public static ContentPatcher.IContentPatcherAPI ContentPatcherApi;
        public static string BriarSingerContentPatcherId = "Teoshen.CP.BriarSinger_Class";

       // public DailyTracker dailyTracker;

        //Initializing the events handler
        public Events eventsHandler;

        //Initializing the mana bar
        private static Texture2D ManaBg;
        private static Texture2D ManaFg;

        //Accessed to update the spellbook of the player
        private static readonly IDictionary<long, SpellBook> SpellBookCache = new Dictionary<long, SpellBook>();

        public override void Entry(IModHelper helper)
        {
            ModEntry.helper = helper;

            InitializeClasses();
            LoadAssets();
            SetUpEvents();
        }

        /// <summary>
        /// Initalizes classes needed for the mod.
        /// </summary>

        //This is the daily tracker for spells that can only be cast once per day.
        private void InitializeClasses()
        {
         //   dailyTracker = new DailyTracker();
         //   eventsHandler = new Events(this, dailyTracker);
        }
       
        //This defines the color of the mana bar and loads it.
        private static void LoadAssets()
        {
            ModEntry.ManaBg = helper.ModContent.Load<Texture2D>("assets/farmer/manabg.png");

            Color manaCol = new Color(120, 48, 255);
            ModEntry.ManaFg = new Texture2D(Game1.graphics.GraphicsDevice, 1, 1);
            ModEntry.ManaFg.SetData(new[] { manaCol });
        }


        //Sets up events for the mod.
        private void SetUpEvents()
        {
            helper.Events.Input.ButtonPressed += eventsHandler.OnButtonPressed;

         //   helper.Events.Display.RenderedHud += eventsHandler.OnRenderedHud;
        //    helper.Events.Display.RenderedWorld += eventsHandler.OnRenderedWorld;

            helper.Events.GameLoop.GameLaunched += eventsHandler.OnGameLaunched;
            //   helper.Events.GameLoop.SaveLoaded += eventsHandler.OnSaveLoaded;
          //  helper.Events.GameLoop.DayStarted += eventsHandler.DayStarted; //Use this to reset mana to max
            

        }
              //Get an updating view of the player's magical metadata.
            public static SpellBook GetSpellBook(Farmer player)
            {
                if (!ModEntry.SpellBookCache.TryGetValue(player.UniqueMultiplayerID, out SpellBook book) || !object.ReferenceEquals(player, book.Player))
                    ModEntry.SpellBookCache[player.UniqueMultiplayerID] = book = new SpellBook(player);
                return book;
            }
        
    }

}
