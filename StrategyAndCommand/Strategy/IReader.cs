namespace StrategyAndCommand.Strategy
{
    public interface IReader
    {
        void OpenReader();
        void CloseReader();
        void SetSource(string source);
        string ReadFromSource();
    }
}
