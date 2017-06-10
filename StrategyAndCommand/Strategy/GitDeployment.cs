using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAndCommand.Strategy
{
    class GitDeployment : ISourceControl
    {
        private bool _deploymentCompleted;

        public void Cleanup()
        {
            Console.WriteLine("Cleaning up Git deployment");
        }

        public void DoDeploymentWork()
        {
            Console.WriteLine("Doing Git deployment work");

            SetDeploymentCompletedStatus(isCompleted: true);
        }

        public void SetupDeployment()
        {
            Console.WriteLine("Setting up Git deployment");

            SetDeploymentCompletedStatus(isCompleted: false);
        }

        public void SetDeploymentCompletedStatus(bool isCompleted)
        {
            _deploymentCompleted = isCompleted;
        }

        public bool IsDeploymentCompleted()
        {
            return _deploymentCompleted;
        }

        public bool IsSourceControlCompleted()
        {
            throw new NotImplementedException();
        }

        public void SetSourceControlCompletedStatus(bool isCompleted)
        {
            throw new NotImplementedException();
        }

        public void SetupSourceControl()
        {
            throw new NotImplementedException();
        }

        public void DoSourceControlWork()
        {
            throw new NotImplementedException();
        }
    }
}
