using System.Collections.Generic;

namespace BilgeWater.Models.Riot
{
    public class MatchDetail
    {
        public int mapId { get; set; }

        public long matchCreation { get; set; }

        public long matchDuration { get; set; }

        public long matchId { get; set; }

        //TODO: Enum/Constants for these
        public string matchMode { get; set; }

        //TODO: CONSTANT
        public string matchType { get; set; }

        public string matchVersion { get; set; }

        public List<ParticipantIdentity> participantIdentities {get; set;} 

        public List<Participant> participants { get; set; }

        public string platformId { get; set; }

        //TODO: CONSTANT
        public string queueType { get; set; }

        //TODO: CONSTANT
        public string region { get; set; }

        //TODO: CONSTANT
        public string season { get; set; }

        public List<Team> teams { get; set; }

        public Timeline timelist { get; set; }
    }
}