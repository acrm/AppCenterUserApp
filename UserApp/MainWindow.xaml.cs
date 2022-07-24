using System.Windows;

namespace UserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var jobDoer = new JobDoer();
            var viewModel = new MainWindowViewModel(jobDoer);
            DataContext = viewModel;
        }
    }
}
