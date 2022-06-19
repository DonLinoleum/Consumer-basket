using SQLite;

namespace mobileApp
{
    [Table("Products")]
    public class Product
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Crossed { get; set; }
    }
}
