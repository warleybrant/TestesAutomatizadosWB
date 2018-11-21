using System;
using System.Collections.Generic;
using System.Linq;

using OrdersSample.Models;

[assembly: Xamarin.Forms.Dependency(typeof(OrdersSample.Services.CustomersDataStore))]
namespace OrdersSample.Services
{
    public class CustomersDataStore : IDataStore<Customer>
    {
        private List<Customer> _items;

        //

        public CustomersDataStore()
        {
            _items = new List<Customer>();

            // Fill default items
            AddItem(new Customer()
            {
                // Product Info
                ProductName = ProductType.MyMoney,
                Quantity = 1,

                // Customer Info
                CustomerName = "John Smith Jr",
                Street = "12, Orange Blvd",
                City = "Grovetown, CA",
                State = "USA",

                // Payment info
                CardName = CardType.Visa,
                CardNumber = "555777555777",
                CardExpireDate = new DateTime(2013, 09, 12)
            });
            AddItem(new Customer()
            {
                // Product Info
                ProductName = ProductType.FamilyAlbum,
                Quantity = 2,

                // Customer Info
                CustomerName = "Clare Jefferson",
                Street = "23, Owk Street",
                City = "Grovetown, CA",
                State = "US",

                // Payment info
                CardName = CardType.MasterCard,
                CardNumber = "770000770000",
                CardExpireDate = new DateTime(2012,03, 3)
            });
            AddItem(new Customer()
            {
                // Product Info
                ProductName = ProductType.MyMoney,
                Quantity = 1,

                // Customer Info
                CustomerName = "Susan McLaren",
                Street = "7, Flower Street",
                City = "Earcastle",
                State = "Great Britan",

                // Payment info
                CardName = CardType.MasterCard,
                CardNumber = "999888777888",
                CardExpireDate = new DateTime(2013,04, 4)
            });
            AddItem(new Customer()
            {
                // Product Info
                ProductName = ProductType.MyMoney,
                Quantity = 1,

                // Customer Info
                CustomerName = "Charles Dodgeson",
                Street = "45, Stone st.",
                City = "Bringtone, TX",
                State = "USA",

                // Payment info
                CardName = CardType.AmericanExpress,
                CardNumber = "333222333222",
                CardExpireDate = new DateTime(2013, 07, 11)
            });
            AddItem(new Customer()
            {
                // Product Info
                ProductName = ProductType.ScreenSaver,
                Quantity = 1,

                // Customer Info
                CustomerName = "Steve Johns",
                Street = "17, Park Avenue",
                City = "Salmon Island",
                State = "Canada",

                // Payment info
                CardName = CardType.MasterCard,
                CardNumber = "444555444555",
                CardExpireDate = new DateTime(2011, 03, 3)
            });
            AddItem(new Customer()
            {
                // Product Info
                ProductName = ProductType.MyMoney,
                Quantity = 2,

                // Customer Info
                CustomerName = "Samuel Clemens",
                Street = "3, Garden st.",
                City = "Hillsberry, UT",
                State = "US",

                // Payment info
                CardName = CardType.MasterCard,
                CardNumber = "123456789012",
                CardExpireDate = new DateTime(2012, 03, 2)
            });
            AddItem(new Customer()
            {
                // Product Info
                ProductName = ProductType.FamilyAlbum,
                Quantity = 1,

                // Customer Info
                CustomerName = "Bob Feather",
                Street = "14, North av.",
                City = "Milltown, WI",
                State = "USA",

                // Payment info
                CardName = CardType.AmericanExpress,
                CardNumber = "111222111222",
                CardExpireDate = new DateTime(2014, 12, 6)
            });
        }

        //

        public void AddItem(Customer item)
        {
            _items.Add(item);
        }

        public void UpdateItem(Customer item)
        {
            var _item = _items.Where((Customer arg) => arg.Id == item.Id).FirstOrDefault();
            _item = item;
        }

        public void DeleteItem(Customer item)
        {
            var _item = _items.Where((Customer arg) => arg.Id == item.Id).FirstOrDefault();
            _items.Remove(_item);
        }

        public Customer GetItem(int id)
        {
            return _items.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Customer> GetItems(bool forceRefresh = false)
        {
            return _items.OrderBy(item => item.Id).ToList();
        }

        public void RefreshItems(bool worksWithBugs)
        {
            _items.ForEach(it => it.UpdateTotal(worksWithBugs));
        }
    }
}