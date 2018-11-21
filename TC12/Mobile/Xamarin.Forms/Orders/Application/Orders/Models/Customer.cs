using OrdersSample.ViewModels;
using System;
using Xamarin.Forms;

namespace OrdersSample.Models
{
    public enum ProductType
    {
        MyMoney,
        FamilyAlbum,
        ScreenSaver
    }

    public enum CardType
    {
        Visa,
        MasterCard,
        AmericanExpress
    }

    public class Customer : BindableObject
    {
        private const int MIN_COUNT_FOR_DISCOUNT = 10;
        private int _id;
        private static int _counter = 0;
        //

        public Customer()
        {
            _id = _counter++;
        }

        public Customer(Customer other) // Full copy
        {
            _id = other.Id;

            Set(other);
        }

        public void Set(Customer other)
        {
            ProductName = other.ProductName;
            Quantity = other.Quantity;

            CustomerName = other.CustomerName;
            Street = other.Street;
            City = other.City;
            State = other.State;

            CardName = other.CardName;
            CardNumber = other.CardNumber;
            CardExpireDate = other.CardExpireDate;
        }

        //------------------------------
        // Product information
        //------------------------------
        public static readonly BindableProperty ProductNameProperty =
            BindableProperty.Create(nameof(ProductName), typeof(ProductType), typeof(Customer), ProductType.FamilyAlbum);
        public ProductType ProductName
        {
            get { return (ProductType)GetValue(ProductNameProperty); }
            set
            {
                SetValue(ProductNameProperty, value);
                OnPropertyChanged("Description");
                OnPropertyChanged("Price");
                OnPropertyChanged("Discount");
                OnPropertyChanged("Total");
            }
        }
        public static readonly BindableProperty QuantityProperty =
            BindableProperty.Create(nameof(Quantity), typeof(int), typeof(Customer), 1);
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set
            {
                SetValue(QuantityProperty, value);
                OnPropertyChanged("Description");
                OnPropertyChanged("Price");
                OnPropertyChanged("Discount");
                OnPropertyChanged("Total");
            }
        }

        public static readonly BindableProperty PriceProperty =
            BindableProperty.Create(nameof(Price), typeof(int), typeof(Customer), 0);
        public int Price
        {
            get
            {
                switch (ProductName)
                {
                    case ProductType.FamilyAlbum:
                        return 100;
                    case ProductType.MyMoney:
                        return 80;
                    case ProductType.ScreenSaver:
                        return 20;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        return 0;
                }
            }
        }

        public static readonly BindableProperty DiscountProperty =
            BindableProperty.Create(nameof(Discount), typeof(int), typeof(Customer), 0);
        public int Discount
        {
            get
            {
                switch (ProductName)
                {
                    case ProductType.FamilyAlbum:
                        return Quantity < MIN_COUNT_FOR_DISCOUNT ? 0 : 8;
                    case ProductType.MyMoney:
                        return Quantity < MIN_COUNT_FOR_DISCOUNT ? 0 : 15;
                    case ProductType.ScreenSaver:
                        return Quantity < MIN_COUNT_FOR_DISCOUNT ? 0 : 10;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        return 0;
                }
            }
        }

        public static readonly BindableProperty TotalProperty =
            BindableProperty.Create(nameof(Total), typeof(int), typeof(Customer), 0);
        public int Total
        {
            get
            {
                return Price * Quantity * (100 - (_worksWithBugs ? 0 : Discount)) / 100;
            }
        }

        //------------------------------
        // Info about customer
        //------------------------------
        public static readonly BindableProperty CustomerNameProperty =
            BindableProperty.Create(nameof(CustomerName), typeof(string), typeof(Customer), string.Empty);
        public string CustomerName
        {
            get { return (string)GetValue(CustomerNameProperty); }
            set { SetValue(CustomerNameProperty, value); }
        }
        public static readonly BindableProperty StreetProperty =
            BindableProperty.Create(nameof(Street), typeof(string), typeof(Customer), string.Empty);
        public string Street
        {
            get { return (string)GetValue(StreetProperty); }
            set { SetValue(StreetProperty, value); }
        }
        public static readonly BindableProperty CityProperty =
            BindableProperty.Create(nameof(City), typeof(string), typeof(Customer), string.Empty);
        public string City
        {
            get { return (string)GetValue(CityProperty); }
            set { SetValue(CityProperty, value); }
        }
        public static readonly BindableProperty StateProperty =
            BindableProperty.Create(nameof(State), typeof(string), typeof(Customer), string.Empty);
        public string State
        {
            get { return (string)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }



        //------------------------------
        // Payment info
        //------------------------------
        public static readonly BindableProperty CardNameProperty =
            BindableProperty.Create(nameof(CardName), typeof(CardType), typeof(Customer), CardType.MasterCard);
        public CardType CardName
        {
            get { return (CardType)GetValue(CardNameProperty); }
            set { SetValue(CardNameProperty, value); }
        }
        public static readonly BindableProperty CardNumberProperty =
            BindableProperty.Create(nameof(CardNumber), typeof(string), typeof(Customer), string.Empty);
        public string CardNumber
        {
            get { return (string)GetValue(CardNumberProperty); }
            set { SetValue(CardNumberProperty, value); }
        }
        public static readonly BindableProperty CardExpireDateProperty =
            BindableProperty.Create(nameof(CardExpireDate), typeof(DateTime), typeof(Customer), DateTime.Now);
        public DateTime CardExpireDate
        {
            get { return (DateTime)GetValue(CardExpireDateProperty); }
            set
            {
                SetValue(CardExpireDateProperty, value);
                OnPropertyChanged("Description");
            }
        }


        //------------------------------
        // Get Description
        //------------------------------
        public static readonly BindableProperty DescriptionProperty =
            BindableProperty.Create(nameof(Description), typeof(string), typeof(Customer), string.Empty);
        public string Description
        {
            get
            {
                return Quantity.ToString() + ", " + ProductName.ToString() + ", " + CardExpireDate.ToString("yyyy.MM.dd");
            }
        }


        //------------------------------
        // Internal info
        //------------------------------
        internal int Id { get { return _id; } }
        private bool _worksWithBugs;

        internal void UpdateTotal(bool worksWithBugs)
        {
            _worksWithBugs = worksWithBugs;
            OnPropertyChanged("Total");
        }
    }
}