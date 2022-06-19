using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            productList.ItemsSource = App.Database.GetItems();
            this.BindingContext = this;
        }    

        private async void AddProduct(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = productEntry.Text;
            product.Strikethrough = Xamarin.Forms.TextDecorations.None;
            productEntry.Text = "";
            App.Database.SaveItem(product);
            productList.ItemsSource = App.Database.GetItems();        
        }

        private async void StrikethroughProductName (object sender, ItemTappedEventArgs e)
        {
           Product selected = e.Item as Product;
            if (selected != null)
            {
                selected.Strikethrough = selected.Strikethrough == TextDecorations.None ? TextDecorations.Strikethrough : TextDecorations.None;
                App.Database.UpdateProduct(selected);
                productList.ItemsSource = App.Database.GetItems();
            }
        }

        private async void DeleteProducts(object sender, EventArgs e)
        {
            App.Database.DeleteItems();
            productList.ItemsSource = App.Database.GetItems();
        }
    }
}
