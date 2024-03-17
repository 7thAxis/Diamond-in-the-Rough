using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.BellsAndWhistles;
using StardewValley.Buildings;
using StardewValley.Characters;
using StardewValley.GameData.Movies;
using StardewValley.Locations;
using StardewValley.Menus;
using StardewValley.Minigames;
using StardewValley.Monsters;
using StardewValley.Network;
using StardewValley.Objects;
using StardewValley.Projectiles;
using StardewValley.TerrainFeatures;
using StardewValley.Tools;
using StardewValley.Util;
using xTile;
using xTile.Dimensions;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Extensions;
using HarmonyLib;
using System.Drawing;
using System.Security.Cryptography;
using Color = Microsoft.Xna.Framework.Color;
using static StardewValley.Minigames.CraneGame;
using xTile.Layers;
using xTile.Tiles;
using StardewValley.ItemTypeDefinitions;
using StardewValley.SpecialOrders;
using System.Threading;

namespace Diamond_in_the_Rough
{
    internal class Patches
    {
        private static IMonitor Monitor;
        
        internal static void resetForNewDay_Prefix(StardewValley.NPC __instance, int dayOfMonth)
        {
            try
            {
                if (__instance.Name == "JeremyTSnail")
                    __instance.forceOneTileWide.Set(true);
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(resetForNewDay_Prefix)}:\n{ex}", LogLevel.Error);
            }
        }
    }
}
