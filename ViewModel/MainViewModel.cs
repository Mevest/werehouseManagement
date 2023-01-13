using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using warehouseManagement.View;

namespace warehouseManagement.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;

        public ICommand ShowDashboardView { get; }
        public ICommand ShowProductsView { get; }
        public ICommand ShowOrdersView { get; }
        public ICommand ShowShipmentsView { get; }
        public ICommand ShowCustomersView { get; }
        public ICommand ShowInvoicesView { get; }

        public MainViewModel()
        {
            ShowDashboardView = new ViewModelCommand(executeDashboardView);
            ShowProductsView = new ViewModelCommand(executeProductsView);
            ShowOrdersView = new ViewModelCommand(executeOrdersView);
            ShowShipmentsView = new ViewModelCommand(executeShipmentsView);
            ShowCustomersView = new ViewModelCommand(executeCustomersView);
            ShowInvoicesView = new ViewModelCommand(executeInvoicesView);
        }

        private void executeDashboardView(object obj)
        {
            CurrentChildView = new DashboardViewModel();
            Caption = "Dashboard";
            Icon = IconChar.Home;
        }

        private void executeProductsView(object obj)
        {
            CurrentChildView = new ProductsViewModel();
            Caption = "Products";
            Icon = IconChar.Warehouse;
        }

        private void executeOrdersView(object obj)
        {
            CurrentChildView = new OrdersViewModel();
            Caption = "Orders";
            Icon = IconChar.Handshake;
        }

        private void executeShipmentsView(object obj)
        {
            CurrentChildView = new ShipmentsViewModel();
            Caption = "Shipments";
            Icon = IconChar.ShippingFast;
        }

        private void executeCustomersView(object obj)
        {
            CurrentChildView = new CustomersViewModel();
            Caption = "Customers";
            Icon = IconChar.UserLarge;
        }

        private void executeInvoicesView(object obj)
        {
            CurrentChildView = new InvoicesViewModel();
            Caption = "Invoices";
            Icon = IconChar.FileInvoice;
        }



        public ViewModelBase CurrentChildView { get => _currentChildView; set { _currentChildView = value; OnPropertyChanged(nameof(CurrentChildView)); } }
        public string Caption { get => _caption; set { _caption = value; OnPropertyChanged(nameof(Caption)); } }
        public IconChar Icon { get => _icon; set { _icon = value; OnPropertyChanged(nameof(Icon)); } }




        
    }
}
