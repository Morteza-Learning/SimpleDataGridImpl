using System.Windows;

namespace SimpleDataGridImpl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new SimpleViewModel();
            //this.DataContext = new ObservableCollectionViewModel();
            this.DataContext = new ObservableCollectionWithNotifyViewModel();
        }
    }
}