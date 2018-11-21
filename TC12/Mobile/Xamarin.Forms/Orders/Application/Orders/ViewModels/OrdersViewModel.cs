using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using OrdersSample.Models;
using OrdersSample.Views;
using System.Linq;

namespace OrdersSample.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        public ObservableCollection<Customer> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public OrdersViewModel()
        {
            Items = new ObservableCollection<Customer>();
            LoadItemsCommand = new Command(() => ExecuteLoadItemsCommand());

            // Subscribe messages

            MessagingCenter.Subscribe<EditItemPage, Customer>(this, "AddItem", (obj, item) =>
            {
                var _item = item as Customer;
                Items.Add(_item);
                DataStore.AddItem(_item);
            });

            MessagingCenter.Subscribe<EditItemPage, Customer>(this, "UpdateItem", (obj, item) =>
            {
                var _item = item as Customer;
                DataStore.UpdateItem(_item);
            });

            MessagingCenter.Subscribe<OrdersPage, Customer>(this, "DeleteItem", (obj, item) =>
            {
                var _item = item as Customer;
                Items.Remove(_item);
                DataStore.DeleteItem(_item);
            });
        }

        protected void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = DataStore.GetItems(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}