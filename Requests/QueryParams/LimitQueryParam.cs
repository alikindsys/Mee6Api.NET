namespace Mee6Api.Requests.QueryParams {
    public class LimitQueryParam : QueryParam {
        public string Key => "limit";
        public string Value { get; }
        
        public LimitQueryParam(int value) {
            Value = value.ToString();
        }

    }
}