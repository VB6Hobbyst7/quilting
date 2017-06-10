namespace StrategyAndCommand.Strategy
{
    using System.Net;

    public class UrlReader : IReader
    {
        WebClient _webClient;
        string _urlSource;

        public void CloseReader()
        {
            _webClient.Dispose();
        }

        public void OpenReader()
        {
            _webClient = new WebClient();
        }

        public string ReadFromSource()
        {
            return _webClient.DownloadString(_urlSource);
        }

        public void SetSource(string source)
        {
            _urlSource = source;
        }
    }
}
