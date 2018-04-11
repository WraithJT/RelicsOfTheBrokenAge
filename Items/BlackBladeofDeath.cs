using Microsoft.Xna.Framework;
using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.Items
{
	public class StrangeSword : ModItem
	{
        public override string Texture
        {
            get { return "Terraria/Item_" + ItemID.EnchantedSword; }
        }

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Blade of Death");
			Tooltip.SetDefault("This sword hungers for souls.");
		}

		public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.EnchantedSword);
            item.color = Color.DarkGray;
            item.damage = 189;
			item.rare = 8;
            //projectile: seeking, piercing?
            //life on hit, constant life drain -- possibly use VanillaUpdateAccessory with an unavailable accessory providing the life drain
            //buff on kill
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ReforgedSoul", 10);
            recipe.AddIngredient(null, "StrangeSword", 1);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.AddRecipe();
        }
    }
}
