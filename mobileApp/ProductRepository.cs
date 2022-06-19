using System.Collections.Generic;
using SQLite;

namespace mobileApp
{
    public class ProductRepository
    {
        SQLiteConnection database;
        public ProductRepository (string databasePath)
        {
            database = new SQLiteConnection (databasePath);
            database.CreateTable<Product>();
        }

        public IEnumerable<Product> GetItems()
        {
            return database.Table<Product>().ToList();
        }
        public int SaveItem(Product item) => database.Insert(item);
        public int DeleteItems() => database.Execute("DELETE FROM Products");
        public int UpdateProduct (Product item) => database.Update(item);
        
    }
}
