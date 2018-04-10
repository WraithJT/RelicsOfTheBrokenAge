using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.Items
{
    public class BrokenSoul : ModItem
    {
        public override string Texture
        {
            get { return "Terraria/Item_" + ItemID.SoulofNight; }
        }

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
    }
}
