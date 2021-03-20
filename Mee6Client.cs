using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Mee6Api.Models;
using Mee6Api.Requests;

namespace Mee6Api {
    public class Mee6Client : IDisposable {
        HttpClient _client;
        Dictionary<ulong, List<Player>> _guildCache = new();

        public Mee6Client() {
            _client = new HttpClient();
        }

        public async Task<List<Player>> GetAllMembersAsync(ulong guildID, bool useCache = true) {
            if (!_guildCache.ContainsKey(guildID) || !useCache) await populateWith(guildID);
            return _guildCache[guildID];
        }

        public async Task<Player> GetMemberDetails(ulong guildID, ulong memberID, bool useCache = true) {
            if (!_guildCache.ContainsKey(guildID) || !useCache) await populateWith(guildID);
            var players = _guildCache[guildID];
            return players.All(x => x.Id != memberID.ToString()) ? null : players.First(x => x.Id == memberID.ToString());
        }

        public Task<Leaderboard> GetLeaderboardAsync(ulong guildId, int limit = 100, int page = 0) 
            => new GetLeaderboardRequest(guildId, limit, page).GetAsync(_client); 
        
        private async Task populateWith(ulong guildId) {
            List<Player> players = new();
            int pageCounter = 0;

            Leaderboard past, current;

            current = await new GetLeaderboardRequest(guildId, 1000, pageCounter).GetAsync(_client);
            while (current.Players.Count == 1000) {
                past = current;
                players.AddRange(past.Players);
                pageCounter++;
                current = await new GetLeaderboardRequest(guildId, 1000, pageCounter).GetAsync(_client);
            }
            players.AddRange(current.Players);
            if (!_guildCache.ContainsKey(guildId)) {
                _guildCache.Add(guildId, players);
            }
            else {
                _guildCache[guildId] = players;
            }
            
        }


        ~Mee6Client() {
            Dispose(false);
        }

        private void ReleaseUnmanagedResources() {
            _guildCache = null;
        }

        private void Dispose(bool disposing) {
            ReleaseUnmanagedResources();
            if (disposing) {
                _client?.Dispose();
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}