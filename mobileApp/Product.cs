using SQLite;
using Xamarin.Forms;

namespace mobileApp
{
    [Table("Products")]
    public class Product
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }

        public Xamarin.Forms.TextDecorations Strikethrough { get; set; }
       
    }
}
