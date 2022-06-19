using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace mobileApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "products_db";
        public static ProductRepository database;
        public static ProductRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProductRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
