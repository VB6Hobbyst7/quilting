using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAndCommand.Template
{
    public class FileReader : ReaderTemplate
    {
        string _readerSource;
        FileReader _reader;

        public override void CloseReader()
        {
            throw new NotImplementedException();
        }

        public override void OpenReader()
        {
            _reader = new FileReader();
            throw new NotImplementedException();
        }

        public override string Read()
        {
            throw new NotImplementedException();
        }

        public override void SetReaderSource(string source)
        {
            _readerSource = source;
        }
    }
}
