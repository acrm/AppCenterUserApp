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
        public event EventHandler<JobDoerResultEventArgs>? OnJobDone;

        private readonly Random _random = new Random();

        public void DoJob()
        {
            var charValue = (char)_random.NextInt64('A', 'Z'+1);
            OnJobDone?.Invoke(this, new JobDoerResultEventArgs(charValue.ToString()));
        }
    }
}
