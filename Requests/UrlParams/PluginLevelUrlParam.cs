namespace Mee6Api.Requests.UrlParams {
    public class PluginLevelUrlParam : UrlParam {
        public string Key => "plugins";
        public string Value => "levels";
        public bool valueOnly => false;
    }
}