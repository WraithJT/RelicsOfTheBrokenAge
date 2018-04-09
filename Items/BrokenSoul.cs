using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.Items
{
    public class BrokenSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Soul");
            //Tooltip.SetDefault("This is a modded sword.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SoulofNight);
            item.color = Color.SlateGray;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
