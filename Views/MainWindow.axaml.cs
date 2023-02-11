using Avalonia.Controls;
using ColoredRectangle.ViewModels;

namespace ColoredRectangle.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
