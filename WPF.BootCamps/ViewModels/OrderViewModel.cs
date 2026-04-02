using System;
using System.Collections.Generic;
using System.Text;
using WPF.BootCamps.Services;
using Microsoft.Extensions.DependencyInjection;
using WPF.BootCamps.Services.Interfaces;
using System.Windows.Input;
using WPF.BootCamps.Helpers;
using WPF.BootCamps.CustomControls.CustomDialog;

namespace WPF.BootCamps.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        // private field 
        private readonly IDialogService _dialogService;

        // public Property 
        public string? Name { get; set; }

        // Command 
        public ICommand? DeleteCommand { get; } // ReadOnly

        public ICommand? OpenAddOrderCommand { get; } // ReadOnly

        public ICommand? LoadCommand { get; } // ReadOnly

        // public Constructor (Constructor Injections)
        public OrderViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            
            DeleteCommand = new RelayCommand(obj => DeleteOrder(obj));

            OpenAddOrderCommand = new RelayCommand(obj => OpenDialog(obj));

            LoadCommand = new AsyncRelayCommand(() => LoadDataAsync());

            // العملية تعمل بالخلفية
            // الواجهة تبقى Responsive 
        }

        // Background Thread 
        public async Task LoadDataAsync()
        {
            await Task.Delay(5000);

            Name = "Loaded Data"; // Safety
        }

        // Show Add Customer Dialog
        public void ShowAddCustomerDialog()
        {
            var dialog = new AddCustomerDialog();
            dialog.ShowDialog();
        }

        // Procedure Open Dialog
        private void OpenDialog(object? obj)
        {
            var dialog = new AddCustomerDialog();
            _dialogService.ShowDialog(dialog);
        }

        // Procedure Delete Order
        private void DeleteOrder(object? obj)
        {
            bool confirm = _dialogService.ShowConfirmation(
                "Are You Sure You Want To Delete This Order ..?", "Confirm");

            if (confirm)
            {
                _dialogService.ShowMessage("Order Deleted","Info");
            }
            /*
             الآن ViewModel لا يعرف أي شيء عن MessageBox.
            فقط يطلب Dialog.
             */
        }

        // Without Dependency Injections 
        //private OrderService _orderService = new OrderService();
        // هنا ViewModel مرتبط مباشرة بالخدمة  Service
        /*
         المشاكل
         1- صعب الاختبار 
         2- صعب تغيير الخدمة 
         3- الكود يصبح متشابك 
         */


        // With Dependency Injections 
        // بدل ان ينشئها 
        // private field 
        //private readonly OrderService _orderService;

        // public Constructor (Constructor Injection)
        //public OrderViewModel(OrderService orderService)
        //{
        //   _orderService = orderService;
        //}
        /*
         Now ViewModel لا يعرف من انشا الخدمة Service 
         فقط يستخدمها 
         هذا يسمى Constructor Injections */

    }
}
