namespace Mee6Api.Requests.QueryParams {
    public class PageQueryParam : QueryParam {
        public string Key => "page";
        public string Value { get; }

        
        public PageQueryParam(int value) {
            Value = value.ToString();
        }

    }
}