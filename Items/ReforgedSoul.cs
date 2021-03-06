﻿using Microsoft.Xna.Framework;
using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.Items
{
    public class ReforgedSoul : ModItem
    {
        public override string Texture
        {
            get { return "Terraria/Item_" + ItemID.SoulofNight; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reforged Soul");
            //Tooltip.SetDefault("This is a modded sword.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SoulofNight);
            item.color = Color.Orange;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "BrokenSoul", 100);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.AddRecipe();
        }
    }
}
