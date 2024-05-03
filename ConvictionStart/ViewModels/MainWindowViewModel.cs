using Avalonia.Remote.Protocol;

namespace ConvictionStart.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainViewModel MainView { get; }
        public MainWindowViewModel()
        {
            MainView = new MainViewModel();
        }
    }
}
