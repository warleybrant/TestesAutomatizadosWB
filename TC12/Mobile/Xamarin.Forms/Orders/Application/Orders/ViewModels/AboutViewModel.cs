using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace OrdersSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://smartbear.com")));
        }

        public ICommand OpenWebCommand { get; }
    }
}