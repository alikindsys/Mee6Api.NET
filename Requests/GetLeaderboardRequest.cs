using Mee6Api.Models;
using Mee6Api.Requests.QueryParams;
using Mee6Api.Requests.UrlParams;

namespace Mee6Api.Requests {
    public class GetLeaderboardRequest : GetRequest<Leaderboard> {
        public GetLeaderboardRequest(ulong guildId) {
            UrlParameters.Add(new PluginLevelUrlParam());
            UrlParameters.Add(new LeaderboardUrlParam(guildId));
        }
        
        public GetLeaderboardRequest(ulong guildId, int limit = 100) {
            UrlParameters.Add(new PluginLevelUrlParam());
            UrlParameters.Add(new LeaderboardUrlParam(guildId));
            
            QueryParameters.Add(new LimitQueryParam(limit));
        }
        public GetLeaderboardRequest(ulong guildId, int limit = 100, int page = 0) {
            UrlParameters.Add(new PluginLevelUrlParam());
            UrlParameters.Add(new LeaderboardUrlParam(guildId));
            
            QueryParameters.Add(new LimitQueryParam(limit));
            QueryParameters.Add(new PageQueryParam(page));
        }
    }
}