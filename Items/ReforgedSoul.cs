using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.Items
{
    public class ReforgedSoul : ModItem
    {
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
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(this, 999);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("ExampleMod:ExampleItem");
            recipe.SetResult(this, 999);
            recipe.AddRecipe();
        }
}
