namespace StrategyAndCommand.Template
{
    using System.Net;

    public class UrlReader : ReaderTemplate
    {
        WebClient _webClient;
        string _urlSource;

        public override void CloseReader()
        {
            _webClient.Dispose();
        }

        public override void OpenReader()
        {
            _webClient = new WebClient();
        }

        public override string Read()
        {
            return _webClient.DownloadString(_urlSource);
        }

        public override void SetReaderSource(string source)
        {
            _urlSource = source;
        }
    }
}
