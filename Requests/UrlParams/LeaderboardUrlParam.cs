namespace Mee6Api.Requests.UrlParams {
    public class LeaderboardUrlParam : UrlParam {
        public LeaderboardUrlParam(ulong guildId) {
            Value = guildId.ToString();
        }

        public string Key => "leaderboard";
        public string Value { get; }
        public bool valueOnly => false;
        
    }
}