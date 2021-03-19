using System.Collections.Generic;
using System.Linq;
using Mee6Api.Requests.Fragments;
using Mee6Api.Requests.QueryParams;
using Mee6Api.Requests.UrlParams;

namespace Mee6Api.Requests {
    public abstract class BaseRequest {
        internal string BaseUrl = "https://mee6.xyz/api/";
        public List<QueryParam> QueryParameters { get; set; } = new();
        public List<UrlParam> UrlParameters { get; set; } = new();
        public List<Fragment> UrlFragments { get; set; } = new();

        public Dictionary<string, string> Headers {get;set;} = new();

        public string Url => string.Join("/", UrlParameters.Select(x => $"{(x.valueOnly ? $"{x.Value}" : $"{x.Key}/{x.Value}")}"));
        public string Fragments => string.Join("/", UrlFragments.Select(x => x.Value));
        public string Query => string.Join("&", QueryParameters.Select(x => $"{x.Key}={x.Value}"));
        public string RequestUrl => $"{BaseUrl}/{Url}{(string.IsNullOrWhiteSpace(Fragments) ? "" : $"/{Fragments}")}{(string.IsNullOrWhiteSpace(Query)?"":$"?{Query}")}";
    }
}