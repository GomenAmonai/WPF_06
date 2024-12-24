using System.Windows;

namespace ProductApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenProductList_Click(object sender, RoutedEventArgs e)
        {
            var productListWindow = new ProductListWindow();
            productListWindow.ShowDialog();
        }
    }
}
