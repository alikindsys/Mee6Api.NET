using System;
using System.Net.Http;
using System.Threading.Tasks;
using Mee6Api.Requests;

namespace Mee6Api.Test {
    class Program {
        static async Task Main(string[] args) {
            using var client = new HttpClient();
            GetLeaderboardRequest request = new(194925640888221698, page:1);
            var leaderboard =  await request.GetAsync(client);
        }
    }
}