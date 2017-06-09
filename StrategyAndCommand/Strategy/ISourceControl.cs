using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAndCommand.Strategy
{
    public interface ISourceControl
    {
        bool IsSourceControlCompleted();
        void SetSourceControlCompletedStatus(bool isCompleted);
        void SetupSourceControl();
        void DoSourceControlWork();
        void Cleanup();
    }
}
