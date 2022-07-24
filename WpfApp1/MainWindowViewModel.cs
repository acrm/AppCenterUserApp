using System;
using System.ComponentModel;

namespace UserApp
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly JobDoer _model;
        private string? _jobReport;

        public MainWindowViewModel(JobDoer model)
        {
            _model = model;
            _model.OnJobDone += (s, e) => JobReport = e.Report;
            DoJobCommand = new RelayCommand(() => _model.DoJob());
        }

        public RelayCommand DoJobCommand { get; }

        public string JobReport
        {
            get => _jobReport ?? string.Empty;
            set
            {
                var oldValue = _jobReport;
                _jobReport = value;
                if (oldValue != value)
                {
                    OnPropertyChange(nameof(JobReport));
                }
            }
        }

        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
