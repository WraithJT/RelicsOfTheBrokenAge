using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RelicsoftheBrokenAge.NPCs
{
    public class RelicsoftheBrokenAgeGlobalNPC : GlobalNPC
    {

        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(10) == 0 && !Main.player[Main.myPlayer].HasItem(mod.ItemType("StrangeSword")) && Main.expertMode) //adds 10% chance to drop Strange Sword on any NPC kill in Expert Mode, if player does not already own one
                Item.NewItem(npc.getRect(), mod.ItemType("StrangeSword"));
        }

    }
}
