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
            if (Main.expertMode && !npc.friendly && npc.lifeMax > 10 && !npc.boss && Main.rand.Next(50) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("BrokenSoul"));
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
