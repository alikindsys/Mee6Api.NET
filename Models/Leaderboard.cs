using System.Collections.Generic;

namespace Mee6Api.Models {
    public class Leaderboard {
        public Guild Guild { get; set; }
        public List<Player> Players { get; set; }
        public int Page { get; set; }
    }
}