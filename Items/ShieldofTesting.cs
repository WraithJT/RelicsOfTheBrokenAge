using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.Items
{
    public class ShieldofTesting : ModItem
    {
        public override string Texture
        {
            get { return "Terraria/Item_" + ItemID.CobaltShield; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shield of Testing");
            Tooltip.SetDefault("Provides damage immunity for testing purposes.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.CobaltShield);
            item.color = Color.Purple;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.immune = true;
            player.immuneAlpha = 0;
        }

        //public override void AddRecipes()
        //{
        //    ModRecipe recipe = new ModRecipe(mod);
        //    recipe.AddIngredient("BrokenSoul", 100);
        //    recipe.SetResult(this, 1);
        //    recipe.AddTile(TileID.DemonAltar);
        //    recipe.AddRecipe();
        //}
    }
}
