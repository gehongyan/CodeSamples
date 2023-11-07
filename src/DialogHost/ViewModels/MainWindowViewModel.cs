using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace DialogHost.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ICommand ShowDialog => ReactiveCommand.Create(() => { IsDialogShown = true; });

    [Reactive]
    public bool IsDialogShown { get; set; }
}
