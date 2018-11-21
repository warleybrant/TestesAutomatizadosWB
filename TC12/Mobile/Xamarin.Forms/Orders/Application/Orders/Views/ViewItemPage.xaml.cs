using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using OrdersSample.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrdersSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewItemPage : ContentPage
    {
        public Customer Item { get; set; }

        public ViewItemPage()
        {
            InitializeComponent();

            Item = new Customer();

            Title = "New item";
            BindingContext = this;
        }

        public ViewItemPage(Customer customer)
        {
            InitializeComponent();

            Item = customer;

            Title = "Edit item";
            BindingContext = this;
        }

        //

        void Edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditItemPage(Item));
        }
    }
}