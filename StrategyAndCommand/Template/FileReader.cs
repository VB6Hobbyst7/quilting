namespace StrategyAndCommand.Template
{
    public class FileReader : ReaderTemplate
    {
        private string _source;

        public override void CloseReader()
        {
        }

        public override void OpenReader()
        {
        }

        public override string Read()
        {
            return System.IO.File.ReadAllText(_source);
        }

        public override void SetReaderSource(string source)
        {
            _source = source;
        }
    }
}
