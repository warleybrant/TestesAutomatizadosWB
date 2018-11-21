using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrdersSample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	}
}