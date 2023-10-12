using System.Collections.ObjectModel;
using System.Linq;

namespace AvaloniaDataGridScrollBinding.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<SyncScrollDataGridItem> SyncScrollDataGridItemsSource =>
        new(Enumerable.Range(1, 100).Select(x =>
            new SyncScrollDataGridItem()
            {
                Name = $"Name {x}",
                Value = $"Value {x}",
            }));
}

public class SyncScrollDataGridItem
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}
