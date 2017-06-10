using System;

namespace StrategyAndCommand.Command
{
    public class AddTwo : ICommand
    {
        public int Execute(int input)
        {
            return input + 2;
        }
    }
}
