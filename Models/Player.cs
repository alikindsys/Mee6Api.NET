using System.Collections.Generic;

namespace Mee6Api.Models {
    public class Player
    {
        public string Avatar { get; set; }
        public List<ulong> DetailedXp { get; set; }
        public long Discriminator { get; set; }
        public string GuildId { get; set; }
        public string Id { get; set; }
        public long Level { get; set; }
        public long MessageCount { get; set; }
        public string Username { get; set; }
        public long Xp { get; set; }
    }
}