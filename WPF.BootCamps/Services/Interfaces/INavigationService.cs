using System;
using System.Collections.Generic;
using System.Text;

namespace WPF.BootCamps.Services.Interfaces
{
    public interface INavigationService
    {
        // Contracts
        public void Navigate<TViewModel>() where TViewModel : notnull;

        object? CurrentView { get; } // ReadOnly

        public void NavigateTo<T>() where T : class;
    }
}
