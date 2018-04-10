using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.NPCs
{
    public class RelicsoftheBrokenAgeGlobalNPC : GlobalNPC
    {
        //public override bool InstancePerEntity
        //{
        //    get
        //    {
        //        return true;
        //    }
        //}


        public override void NPCLoot(NPC npc)
        {
            //Drop Broken Souls from any non-boss Expert mode NPC with life >10 while player has Strange Sword
            if (Main.expertMode && !npc.friendly && npc.lifeMax > 10 && !npc.boss && /*Main.player.HasItem(mod.ItemType("StrangeSword")) &&*/ Main.rand.Next(50) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("BrokenSoul"));
            //Drop Strange Sword from zombies
            if (Main.expertMode && npc.type == NPCID.Zombie && Main.rand.Next(100) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("StrangeSword"));
        }

        //public override void DrawEffects(NPC npc, ref Color drawColor)
        //{

        //}

        //public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        //{

        //}

        //public override void SetupShop(int type, Chest shop, ref int nextSlot)
        //{

        //}
    }
}
