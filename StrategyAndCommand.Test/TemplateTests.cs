namespace StrategyAndCommand.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;

    [TestClass]
    public class TemplateTests
    {
        [TestMethod]
        public void ReadATextFile()
        {
            string binDirectory = System.IO.Directory.GetCurrentDirectory();
            string currentPath = Directory.GetParent(binDirectory).Parent.FullName;
            string pathToFile = $"{currentPath}\\README.md";
            var fileReader = new StrategyAndCommand.Template.FileReader();

            var text = fileReader.ReadFromSource(pathToFile);
            Assert.IsFalse(string.IsNullOrWhiteSpace(text));
        }
    }
}
