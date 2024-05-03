using ConvictionStart.ViewModels;

namespace ConvictionStart.DesignTimeData;

public class DesignMainViewModel : MainViewModel
{
    public DesignMainViewModel()
    {
        FilesToUpdate.AddRange(["file1", "file2"]);
    }
}
