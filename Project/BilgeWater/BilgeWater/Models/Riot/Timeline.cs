using System.Collections.Generic;

namespace BilgeWater.Models.Riot
{
    public class Timeline
    {
        public long frameInterval { get; set; }

        public List<Frame> frames { get; set; }
    }
}