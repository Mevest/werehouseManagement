using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace warehouseManagement.View
{
    /// <summary>
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView : UserControl, INotifyPropertyChanged
    {
        public ProductsView()
        {
            InitializeComponent();
        }
        private void AddNewProduct(object sender, RoutedEventArgs e)
        {
          
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
