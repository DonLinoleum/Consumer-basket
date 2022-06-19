using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobileApp
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            productList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void AddProduct(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = productEntry.Text;
            productEntry.Text = "";
            App.Database.SaveItem(product);
            productList.ItemsSource = App.Database.GetItems();
        }

        private async void CrossProductName (object sender, ItemTappedEventArgs e)
        {

        }

        private async void DeleteProducts(object sender, EventArgs e)
        {
            App.Database.DeleteItems();
            productList.ItemsSource = App.Database.GetItems();
        }
    }
}
