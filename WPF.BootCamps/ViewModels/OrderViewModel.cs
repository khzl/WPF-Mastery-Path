using System;
using System.Collections.Generic;
using System.Text;
using WPF.BootCamps.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WPF.BootCamps.ViewModels
{
    public class OrderViewModel
    {
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
        private readonly OrderService _orderService;

        // public Constructor (Constructor Injection)
        public OrderViewModel(OrderService orderService)
        {
            _orderService = orderService;
        }
        /*
         Now ViewModel لا يعرف من انشا الخدمة Service 
         فقط يستخدمها 
         هذا يسمى Constructor Injections */

    }
}
