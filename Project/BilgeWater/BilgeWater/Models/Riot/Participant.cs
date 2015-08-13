using System.Collections.Generic;

namespace BilgeWater.Models.Riot
{
    public class Participant
    {
        public int championId { get; set; }

        //TODO: CONSTANT
        public string highestAchievedSeasonTier { get; set; }

        public List<Mastery> masteries { get; set; }
        
        public int participantId { get; set; }

        public List<Rune> runes { get; set; }

        public int spell1Id { get; set; }

        public int spell2Id { get; set; }

        public ParticipantStats stats { get; set; }

        public int teamId { get; set; }

        public ParticipantTimeline timeline { get; set; }
    }
}