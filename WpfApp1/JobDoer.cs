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

        private int _counter = 0;

        public void DoJob()
        {
            _counter++;
            OnJobDone?.Invoke(this, new JobDoerResultEventArgs(_counter.ToString()));
        }
    }
}
