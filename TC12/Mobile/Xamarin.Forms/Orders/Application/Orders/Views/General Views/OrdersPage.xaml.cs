using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using OrdersSample.Models;
using OrdersSample.ViewModels;

namespace OrdersSample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrdersPage : ContentPage
	{
        public OrdersPage()
        {
            InitializeComponent();
        }

        //--

        void NewItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditItemPage());

            // Deselect
            ItemsListView.SelectedItem = null;
        }

        void EditItem_Clicked(object sender, EventArgs args)
        {
            var mi = ((MenuItem)sender);
            Navigation.PushAsync(new EditItemPage(mi.CommandParameter as Customer));

            // Deselect
            ItemsListView.SelectedItem = null;
        }

        async void DeleteItem_Clicked(object sender, EventArgs args)
        {
            var answer = await DisplayAlert("Orders Demo", "Do you want to delete selected order?", "Yes", "No");
            if (!answer) return;

            var mi = ((MenuItem)sender);
            MessagingCenter.Send(this, "DeleteItem", mi.CommandParameter as Customer);

            // Deselect
            ItemsListView.SelectedItem = null;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (ItemsListView.SelectedItem == null)
            {
                return;
            }

            Navigation.PushAsync(new ViewItemPage(args.SelectedItem as Customer));

            // Deselect
            ItemsListView.SelectedItem = null;
        }

        //


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!(BindingContext is OrdersViewModel))
            {
                return;
            }

            if ((BindingContext as OrdersViewModel).Items.Count == 0)
            {
                (BindingContext as OrdersViewModel).LoadItemsCommand.Execute(null);
            }
        }
    }
}