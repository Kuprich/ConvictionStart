namespace ConvictionStart.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string OnTopMessage { get; set; } = "Следующие файлы доступны для обновления";
    public string UpdateButtonText { get; set; } = "Обновить";
}
