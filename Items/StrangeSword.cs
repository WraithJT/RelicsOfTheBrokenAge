using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.Items
{
	public class StrangeSword : ModItem
	{
        public override string Texture
        {
            get { return "Terraria/Item_" + ItemID.CopperShortsword; }
        }

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strange Sword");
            Tooltip.SetDefault("This sword hums with a strange power." + "\n[c/EC7063:Relic]");
        }
		public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.CopperShortsword);
            item.color = Color.SlateGray;
            item.damage = 10;
			item.value = 0;
			item.rare = -1;
		}
	}
}
