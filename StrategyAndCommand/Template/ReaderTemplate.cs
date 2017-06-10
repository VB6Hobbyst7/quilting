namespace StrategyAndCommand.Template
{
    public abstract class ReaderTemplate
    {
        string _readerSource;
        public abstract void SetReaderSource(string source);

        public abstract void OpenReader();

        public abstract void CloseReader();

        public abstract string Read();

        public string ReadFromSource(string source)
        {
            SetReaderSource(source);

            OpenReader();

            var readerData = Read();

            CloseReader();

            return readerData;
        }
    }
}
