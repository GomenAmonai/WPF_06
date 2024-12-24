using System.Collections.ObjectModel;
using System.Windows;

namespace ProductApp
{
    public partial class ProductTileWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductTileWindow(ObservableCollection<Product> products)
        {
            InitializeComponent();
            Products = products;
            DataContext = this;
        }
    }
}
