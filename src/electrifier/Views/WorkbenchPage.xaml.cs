using electrifier.Views;
using electrifier.ViewModels;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using static System.Net.WebRequestMethods;

// This is taken from -->
//    https://learn.microsoft.com/de-de/dotnet/communitytoolkit/windows/primitives/wrappanel
namespace electrifier.Views;

public sealed partial class WorkbenchPage : Page
{
    public WorkbenchViewModel ViewModel
    {
        get;
    }

    public WorkbenchPage()
    {
        ViewModel = App.GetService<WorkbenchViewModel>();
        InitializeComponent();
    }

    private void BtnAddRandomSizedImage_Click(object sender, RoutedEventArgs e)
    {
        WrapPanelContainer.Items.Add(new Button { Content = "Hello" });
    }
    private void BtnAddFixedSizedImage_Click(object sender, RoutedEventArgs e)
    {
        WrapPanelContainer.Items.Add(new Button { Content = "Hello" });
    }
    private void BtnSwitchOrientation_Click(object sender, RoutedEventArgs e)
    {
        WrapPanelContainer.Items.Add(new Button { Content = "Hello" });
    }
}
