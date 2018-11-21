using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using OrdersSample.Models;
using OrdersSample.Services;

namespace OrdersSample.ViewModels
{
    public class BaseViewModel : BindableObject
    {
        public IDataStore<Customer> DataStore => DependencyService.Get<IDataStore<Customer>>() ?? new CustomersDataStore();

        // Busy

        public static readonly BindableProperty BusyProperty = 
            BindableProperty.Create(nameof(IsBusy), typeof(bool), typeof(BaseViewModel), false);
        public bool IsBusy
        {
            get { return (bool)GetValue(BusyProperty); }
            set { SetValue(BusyProperty, value); }
        }
    }
}
