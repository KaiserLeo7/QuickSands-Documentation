using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class BattleQuest : Quest
    {
        private NestDB nestDB = new NestDB();
        private System.Random random = new System.Random();
        private PlayerData playerData = new PlayerData();
        public BattleQuest()
        {
            this.QuestLocation = (Nest)nestDB.getNest(random.Next(0, 3));

            this.questDescription = "Defeat the " + questLocation.LocationName + " Nest";

            if (playerData.CurrentLocation.Territory != questLocation.Territory)
                {
                    this.questReward = random.Next(400*(Nest)(this.QuestLocation). , 501);
                    this.distanceNote = "Far away";
                }
                else
                {
                    this.questReward = random.Next(300, 401);
                    this.distanceNote = "Nearby";
                }
        }
    }
}