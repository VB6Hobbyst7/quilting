namespace StrategyAndCommand.Test
{
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void RunWithNoPipeline()
        {
            var emptyPipeline = new List<StrategyAndCommand.Command.ICommand>();
            var pipeline = new StrategyAndCommand.Command.Pipeline(emptyPipeline);

            var result = pipeline.Run();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void RunAPipeline()
        {
            var fullPipeLine = new List<StrategyAndCommand.Command.ICommand>
            {
                new StrategyAndCommand.Command.AddTwo(),
                new StrategyAndCommand.Command.MultiplyByFive(),
                new StrategyAndCommand.Command.AddTwo(),
                new StrategyAndCommand.Command.DivideByThree()
            };
            var pipeline = new StrategyAndCommand.Command.Pipeline(fullPipeLine);

            var result = pipeline.Run();

            Assert.AreEqual(4, result);
        }
    }
}
