using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.Items
{
	public class StrangeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strange Sword");
			Tooltip.SetDefault("This sword hums with a strange power.");
		}

		public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.CopperShortsword);
            item.damage = 10;
			item.rare = 1;
		}
	}
}
