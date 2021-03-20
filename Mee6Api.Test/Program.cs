using System;
using System.Net.Http;
using System.Threading.Tasks;
using Mee6Api.Requests;

namespace Mee6Api.Test {
    class Program {
        static async Task Main(string[] args) {
            using var client = new Mee6Client();
            var leaderboard = await client.GetLeaderboardAsync(194925640888221698);
            var members = await client.GetAllMembersAsync(194925640888221698);
            var paulo = await client.GetMemberDetails(194925640888221698, 155774074885242880);
        }
    }
}