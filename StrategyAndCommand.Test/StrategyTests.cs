namespace StrategyAndCommand.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class StrategyTests
    {
        [Test]
        public void ReadATextFile()
        {
            string currentPath = TestContext.CurrentContext.TestDirectory;
            string pathToFile = $"{currentPath}\\README.md";

            var fileReader = new StrategyAndCommand.Strategy.FileReader();
            var readerRunner = new StrategyAndCommand.Strategy.ReaderRunner(fileReader);

            var text = readerRunner.Run(pathToFile);

            Assert.IsFalse(string.IsNullOrWhiteSpace(text));
        }

        [Test]
        public void ReadFromAUrl()
        {
            string url = "https://www.google.com";

            var urlReader = new StrategyAndCommand.Strategy.UrlReader();
            var readerRunner = new StrategyAndCommand.Strategy.ReaderRunner(urlReader);

            var text = readerRunner.Run(url);

            Assert.IsFalse(string.IsNullOrWhiteSpace(text));
        }
    }
}
