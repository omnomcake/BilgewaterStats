﻿using System.Collections.Generic;

namespace BilgeWater.Models.Riot
{
    public class Team
    {
        public List<BannedChampion> bans { get; set; }

        public int baronKills { get; set; }

        public long dominionVictoryScore { get; set; }

        public int dragonKills { get; set; }

        public bool firstBaron { get; set; }

        public bool firstBlood { get; set; }

        public bool firstDragon { get; set; }

        public bool firstInhibitor { get; set; }

        public bool firstTower { get; set; }

        public int inhibitorKills { get; set; }

        public int teamId { get; set; }

        public int towerKills { get; set; }

        public int vilemawKills { get; set; }

        public bool winner { get; set; }
    }
}