using System.Collections.ObjectModel;
using System.Windows;

namespace ProductApp
{
    public partial class ProductListWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public ProductListWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            var newProduct = new Product();
            var dialog = new EditProductDialog(newProduct);
            if (dialog.ShowDialog() == true)
            {
                Products.Add(newProduct);
            }
        }

        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListView.SelectedItem is Product selectedProduct)
            {
                var clonedProduct = new Product
                {
                    Name = selectedProduct.Name,
                    Quantity = selectedProduct.Quantity,
                    Unit = selectedProduct.Unit
                };

                var dialog = new EditProductDialog(clonedProduct);
                if (dialog.ShowDialog() == true)
                {
                    selectedProduct.Name = clonedProduct.Name;
                    selectedProduct.Quantity = clonedProduct.Quantity;
                    selectedProduct.Unit = clonedProduct.Unit;
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }
    }
}
