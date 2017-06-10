namespace StrategyAndCommand.Strategy
{
    public class ReaderRunner
    {
        IReader _reader;

        public ReaderRunner(IReader reader)
        {
            _reader = reader;
        }

        public string Run(string source)
        {
            _reader.SetSource(source);

            _reader.OpenReader();

            string text = _reader.ReadFromSource();

            _reader.CloseReader();

            return text;
        }
    }
}
