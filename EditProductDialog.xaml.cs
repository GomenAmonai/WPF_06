using System;
using System.Windows;

namespace ProductApp
{
    public partial class EditProductDialog : Window
    {
        public EditProductDialog(Product product)
        {
            InitializeComponent();

            DataContext = product;
            Resources["UnitTypes"] = Enum.GetValues(typeof(UnitType));
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
