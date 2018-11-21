using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using OrdersSample.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrdersSample.Views
{
    internal enum EditMode
    {
        CreateNewItem,
        EditExistsItem
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditItemPage : ContentPage
    {
        internal EditMode Mode { get; set; }
        public Customer Item { get; set; }
        public Customer EditingItem { get; set; }

        public EditItemPage()
        {
            InitializeComponent();

            Mode = EditMode.CreateNewItem;
            Item = null;
            EditingItem = new Customer();

            Title = "New item";
            BindingContext = this;
        }

        public EditItemPage(Customer customer)
        {
            InitializeComponent();

            Mode = EditMode.EditExistsItem;
            Item = customer;
            EditingItem = new Customer(Item);

            Title = "Edit item";
            BindingContext = this;
        }

        //

        void Save_Clicked(object sender, EventArgs e)
        {
            if (Mode == EditMode.CreateNewItem)
            {
                MessagingCenter.Send(this, "AddItem", EditingItem);
            }
            else if(Mode == EditMode.EditExistsItem)
            {
                Item.Set(EditingItem);
                MessagingCenter.Send(this, "UpdateItem", Item);
            }
            else
            {
                System.Diagnostics.Debug.Assert(false);
            }
            
            GoBack();
        }

        void Cancel_Clicked(object sender, EventArgs e)
        {
            GoBack();
        }


        private void GoBack()
        {
            Navigation.PopAsync(false);
            if (Mode == EditMode.EditExistsItem)
            {
                Navigation.PopAsync(false);
            }
        }
    }
}