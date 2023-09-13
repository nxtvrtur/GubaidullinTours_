using System.Windows;
using System.Windows.Controls;

namespace GubaidullinTourss;

public partial class HotelsPage : Page
{
    public HotelsPage()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        Manager.MainFrame.Navigate(new AddEditPage());
    }
}