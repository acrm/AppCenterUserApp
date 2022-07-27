using System;

namespace UserApp
{
    public class JobDoerResultEventArgs : EventArgs
    {
        public JobDoerResultEventArgs(string report) => Report = report;

        public string Report { get; }
    }

    internal class JobDoer
    {
        public event EventHandler<JobDoerResultEventArgs> OnJobDone;

        private readonly Random _random = new Random();

        public void DoJob()
        {
            var numberValue = _random.Next(1, 100);
            OnJobDone?.Invoke(this, new JobDoerResultEventArgs(numberValue.ToString()));
        }
    }
}
