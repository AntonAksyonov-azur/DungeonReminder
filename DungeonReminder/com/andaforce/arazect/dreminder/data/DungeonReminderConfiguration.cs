using System;
using System.Collections.Generic;
using DungeonReminder.com.andaforce.arazect.axna.configuration;

namespace DungeonReminder.com.andaforce.arazect.dreminder.data
{
    public class DungeonReminderConfiguration : IConfigurationObject
    {
        public DateTime LastUpdated;
        public List<DungeonData> Dungeon;

        public void InitDefault()
        {
            LastUpdated = DateTime.Now;
            Dungeon = new List<DungeonData>();
        }
    }

    public class DungeonData
    {
        public String DungeonName;
        public String PathName;
        public Single GoldReward;
        public bool IsCompleted;

        public DungeonData(string dungeonName, string pathName, float goldReward)
        {
            DungeonName = dungeonName;
            PathName = pathName;
            GoldReward = goldReward;
        }
    }
}