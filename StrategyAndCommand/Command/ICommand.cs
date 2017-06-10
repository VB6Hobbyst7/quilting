using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndCommand.Command
{
    public interface ICommand
    {
        int Execute(int input);
    }
}
