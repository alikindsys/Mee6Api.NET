using System;

namespace Mee6Api.Models {
    public class Guild
    {
        public bool AllowJoin { get; set; }
        public string Icon { get; set; }
        public string Id { get; set; }
        public bool InviteLeaderboard { get; set; }
        public Uri LeaderboardUrl { get; set; }
        public string Name { get; set; }
        public bool Premium { get; set; }
    }
}