using System;

namespace StrategyAndCommand.Command
{
    public class DivideByThree : ICommand
    {
        public int Execute(int input)
        {
            return input / 3;
        }
    }
}
