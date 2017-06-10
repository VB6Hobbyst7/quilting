using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAndCommand.Strategy
{
    class TfsSourceControl : ISourceControl
    {
        private bool _SourceControlCompleted;
        private Random _randomObject;

        public void Cleanup()
        {
            Console.WriteLine("Cleaning up Tfs SourceControl");
        }

        public void DoSourceControlWork()
        {
            Console.WriteLine("Doing Tfs SourceControl work");

            SetSourceControlCompletedStatus(isCompleted: true);
        }

        public void SetupSourceControl()
        {
            Console.WriteLine("Setting up Tfs SourceControl");

            SetSourceControlCompletedStatus(isCompleted: false);
        }

        public void SetSourceControlCompletedStatus(bool isCompleted)
        {
            _SourceControlCompleted = isCompleted;
        }

        public bool IsSourceControlCompleted()
        {
            return _SourceControlCompleted;
        }
    }
}
