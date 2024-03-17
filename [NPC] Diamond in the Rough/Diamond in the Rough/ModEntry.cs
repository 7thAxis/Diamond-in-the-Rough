using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using HarmonyLib;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;


namespace Diamond_in_the_Rough
{
    public partial class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.SaveLoaded += this.SaveLoaded; 
            var harmony = new Harmony(this.ModManifest.UniqueID);
            harmony.Patch(
                original: AccessTools.Method(typeof(StardewValley.NPC), "resetForNewDay"),
                prefix: new HarmonyMethod(typeof(Patches), nameof(Patches.resetForNewDay_Prefix))
            );
        }
        public void SaveLoaded(object sender, SaveLoadedEventArgs e)
        {
             Game1.getCharacterFromName("JeremyTSnail").forceOneTileWide.Set(true);
        }
    }
}
