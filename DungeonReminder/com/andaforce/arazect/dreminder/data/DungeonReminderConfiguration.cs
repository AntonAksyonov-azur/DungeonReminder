using System;
using System.Collections.Generic;
using DungeonReminder.com.andaforce.arazect.axna.configuration;

namespace DungeonReminder.com.andaforce.arazect.dreminder.data
{
    public class DungeonReminderConfiguration : IConfigurationObject
    {
        public DateTime LastUpdated;
        public List<Dungeon> Dungeons;

        public void InitDefault()
        {
            LastUpdated = DateTime.Now;
            Dungeons = new List<Dungeon>()
            {
                new Dungeon() {DungeonName = "Ascalonian Catacombs", PathName = "PathName 1", GoldReward = 1.5f},
                new Dungeon() {DungeonName = "Ascalonian Catacombs", PathName = "PathName 2", GoldReward = 1.5f},
                new Dungeon() {DungeonName = "Ascalonian Catacombs", PathName = "PathName 3", GoldReward = 1.5f}
            };
        }
    }

    public class Dungeon
    {
        public String DungeonName { get; set; }
        public String PathName { get; set; }
        public Single GoldReward { get; set; }
        public bool IsCompleted { get; set; }
    }

}