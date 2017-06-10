using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndCommand.Command
{
    public class MultiplyByFive : ICommand
    {
        public int Execute(int input)
        {
            return input * 5;
        }
    }
}
