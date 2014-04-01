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
                new Dungeon() {DungeonName = "Ascalonian Catacombs", PathName = "Path 1 - Hodgins", GoldReward = 1.5f},
                new Dungeon() {DungeonName = "Ascalonian Catacombs", PathName = "Path 2 - Detha", GoldReward = 1.5f},
                new Dungeon() {DungeonName = "Ascalonian Catacombs", PathName = "Path 3 - Tzark", GoldReward = 1.5f},

                new Dungeon() {DungeonName = "Caudecus's Manor", PathName = "Path 1 - Asura", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Caudecus's Manor", PathName = "Path 2 - Seraph", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Caudecus's Manor", PathName = "Path 3 - Butler", GoldReward = 1.0f},

                new Dungeon() {DungeonName = "Twilight Arbor", PathName = "Path 1 - Leurent (Up)", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Twilight Arbor", PathName = "Path 3 - Vevina (Forward)", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Twilight Arbor", PathName = "Path 4 - Aetherpath", GoldReward = 2.0f},

                new Dungeon() {DungeonName = "Sorrow's Embrace", PathName = "Path 1 - Fergg", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Sorrow's Embrace", PathName = "Path 2 - Rasolov", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Sorrow's Embrace", PathName = "Path 3 - Koptev", GoldReward = 1.0f},

                new Dungeon() {DungeonName = "Citadel of Flame", PathName = "Path 1 - Ferrah", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Citadel of Flame", PathName = "Path 2 - Magg", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Citadel of Flame", PathName = "Path 3 - Rhiannon", GoldReward = 1.0f},

                new Dungeon() {DungeonName = "Honor of the Waves", PathName = "Path 1 - Butcher", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Honor of the Waves", PathName = "Path 2 - Plunderer", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Honor of the Waves", PathName = "Path 3 - Zealot", GoldReward = 1.0f},

                new Dungeon() {DungeonName = "Crucible of Eternity", PathName = "Path 1 - Submarine", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Crucible of Eternity", PathName = "Path 2 - Teleporter", GoldReward = 1.0f},
                new Dungeon() {DungeonName = "Crucible of Eternity", PathName = "Path 3 - Front d", GoldReward = 1.0f},

                new Dungeon() {DungeonName = "The Ruined City of Arah", PathName = "Path 1 - Jotun", GoldReward = 3.0f},
                new Dungeon() {DungeonName = "The Ruined City of Arah", PathName = "Path 2 - Mursaat", GoldReward = 3.0f},
                new Dungeon() {DungeonName = "The Ruined City of Arah", PathName = "Path 3 - Forgotten", GoldReward = 1.5f},
                new Dungeon() {DungeonName = "The Ruined City of Arah", PathName = "Path 4 - Seer", GoldReward = 3.0f}
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