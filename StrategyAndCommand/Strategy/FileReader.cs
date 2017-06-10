using System;

namespace StrategyAndCommand.Strategy
{
    public class FileReader : IReader
    {
        private string _source;

        public void CloseReader()
        {
        }

        public void OpenReader()
        {
        }

        public string ReadFromSource()
        {
            return System.IO.File.ReadAllText(_source);
        }

        public void SetSource(string source)
        {
            _source = source;
        }
    }
}
