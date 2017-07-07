using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using csharp_wpf_exercise.Models;
using csharp_wpf_exercise.ViewModels;

namespace csharp_wpf_exercise.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            var view = new CustomerView();
            var viewModel = new CustomerViewModel();
            view.DataContext = viewModel;
            view.ShowDialog();
        }
    }
}
