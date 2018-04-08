using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;

namespace RelicsoftheBrokenAge.Items
{
    public class BlackBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Blade");
            Tooltip.SetDefault("This sword hungers for souls." + "\n[c/EB6E00:Relic]");
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[0].overrideColor = new Color(235, 110, 0); //Changes item name color
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Muramasa);
            item.damage = 48;
            item.value = 0;
            item.rare = 3;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 299, 0f, 0f, 0, new Color(0, 0, 0), 1f);
            }
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            player.AddBuff(113, 120); //Adds 20% health buff on hit
        }


    }
}
