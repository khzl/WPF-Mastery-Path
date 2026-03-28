using System;
using System.Collections.Generic;
using System.Text;
using WPF.BootCamps.Services.Interfaces;
using WPF.BootCamps.ViewModels;
using Microsoft.Extensions.DependencyInjection;
namespace WPF.BootCamps.Services
{
    public class NavigationService : BaseViewModel , INavigationService
    {
        // private field 
        private readonly MainViewModel _mainViewModel;
        private readonly IServiceProvider _serviceProvider;
        private object? _currentView;

        // public Property
        public object? CurrentView
        {
            get => _currentView;
            private set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        // public Constructor (Constructor Injections)
        public NavigationService(MainViewModel mainViewModel , IServiceProvider serviceProvider)
        {
            this._mainViewModel = mainViewModel;
            this._serviceProvider = serviceProvider;
        }

        // Navigate

        public void NavigateTo<T>() where T : class
        {
            CurrentView = _serviceProvider.GetRequiredService<T>();
        }

        public void Navigate<TViewModel>() where TViewModel : notnull
        {
            var viewModel = _serviceProvider.GetRequiredService<TViewModel>();
            _mainViewModel.CurrentView = viewModel;
        }

        /* 
         * ما الذي يحدث هنا؟
         * يحصل على ViewModel من DI Container
         * يضعه في CurrentView
         * الواجهة تتغير تلقائيًا عبر DataTemplate
         * نفس فكرة اليوم 15 لكن بطريقة احترافية.
         */

    }
}
