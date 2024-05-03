using System.Collections.Generic;

namespace ConvictionStart.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string OnTopMessage { get; set; } = "Следующие файлы доступны для обновления";
    public string UpdateButtonText { get; set; } = "Обновить";
    public List<string> FilesToUpdate { get; set; } = new List<string>();
}
