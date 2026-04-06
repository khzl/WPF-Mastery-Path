using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using YourApp.ProjectArchitecture.Commands;
using YourApp.ProjectArchitecture.Helper;
using YourApp.ProjectArchitecture.Models;
using YourApp.ProjectArchitecture.Services.Dialog;

namespace YourApp.ProjectArchitecture.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        // property Orders
        public ObservableCollection<ClientModel_Order> Orders { get; set; } = new ObservableCollection<ClientModel_Order>();

        // private field 
        private readonly IDialogService _dialogService;

        // Command 
        public ICommand? LoadCommand { get; } // ReadOnly

        public ICommand? AddOrderCommand { get; } // ReadOnly
        public ICommand? DeleteCommand { get; } // ReadOnly
        // private field
        private bool _isLoading;

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        // Constructor
        public OrdersViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            AddOrderCommand = new RelayCommand(AddOrder);
            DeleteCommand = new RelayCommand(DeleteOrder);
            LoadCommand = new AsyncRelayCommand(_ => LoadAsync());
        }

        // Delete Order
        private void DeleteOrder(object? obj)
        {
            if (obj is ClientModel_Order clientModel_Orders)
            {
                bool confirm = _dialogService.ShowConfirmation("Delete?", "Confirm");

                if (confirm)
                    Orders.Remove(clientModel_Orders);
            }
        }

        // Add Order
        private void AddOrder(object? obj)
        {
            string? orderName = _dialogService.ShowAddOrderDialog();

            if (orderName != null)
            {
                // user click save 
                // like 
                Orders.Add(new ClientModel_Order
                {
                    OrderId = Orders.Count + 1,
                    OrderName = orderName
                });
            }
        }

        // Load Async
        private async Task LoadAsync()
        {
            IsLoading = true;

            await Task.Delay(1500);

            Orders.Clear();
            Orders.Add(new ClientModel_Order
            {
                OrderId = 1,
                OrderName = "Order A"
            });
            Orders.Add(new ClientModel_Order
            {
                OrderId = 2,
                OrderName = "Order B"
            });

            IsLoading = false;
        }

        // Property
        public string? Title => "Orders Screen";
    }
}
