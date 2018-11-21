using OrdersSample.Models;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace OrdersSample.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public static readonly BindableProperty WorkWithBugsProperty =
            BindableProperty.Create(nameof(WorkWithBugs), typeof(bool), typeof(SettingsViewModel), false);
        public bool WorkWithBugs
        {
            get { return (bool)GetValue(WorkWithBugsProperty); }
            set
            {
                SetValue(WorkWithBugsProperty, value);
                DataStore.RefreshItems(value);
            }
        }
    }
}