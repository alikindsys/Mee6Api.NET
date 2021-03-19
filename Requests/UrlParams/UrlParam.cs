namespace Mee6Api.Requests.UrlParams {
    public interface UrlParam {
        string Key { get; }
        string Value { get; }
        public bool valueOnly { get; }
    }
}