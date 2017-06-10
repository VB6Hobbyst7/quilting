using System;
using System.Collections.Generic;
using System.Linq;
namespace StrategyAndCommand.Command
{
    public class Pipeline
    {
        IEnumerable<ICommand> _commands;
        int _value;

        public Pipeline(IEnumerable<ICommand> commands)
        {
            _value = 0;
            _commands = commands;
        }


        public int Run()
        {
            foreach (var command in _commands)
            {
                _value = command.Execute(_value);
            }

            return _value;
        }
    }
}
