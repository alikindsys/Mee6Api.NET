using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mee6Api.Requests {
    public abstract class GetRequest<T> : BaseRequest {
        public async Task<T> GetAsync(HttpClient client) {
            var responseString = await client.GetStringAsync(RequestUrl);
            return JsonConvert.DeserializeObject<T>(responseString);
        }
    }
}