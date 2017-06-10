namespace StrategyAndCommand.Test
{
    using NUnit.Framework;
    using System.IO;

    [TestFixture]
    public class TemplateTests
    {
        [Test]
        public void ReadATextFile()
        {
            string currentPath = TestContext.CurrentContext.TestDirectory;
            string pathToFile = $"{currentPath}\\README.md";
            var fileReader = new StrategyAndCommand.Template.FileReader();

            var text = fileReader.ReadFromSource(pathToFile);

            Assert.IsFalse(string.IsNullOrWhiteSpace(text));
        }

        [Test]
        public void ReadFromAUrl()
        {
            string url = "https://www.google.com";
            var urlReader = new StrategyAndCommand.Template.UrlReader();

            var text = urlReader.ReadFromSource(url);

            Assert.IsFalse(string.IsNullOrWhiteSpace(text));
        }
    }
}
