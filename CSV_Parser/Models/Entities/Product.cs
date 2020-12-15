
using CsvHelper.Configuration.Attributes;

namespace CSV_Parser.Models.Entities
{
    public class Product
    {
        [Name("id")]
        public int Id { get; set; }

        [Name("product_name")]
        public string ProductName { get; set; }

        [Name("customer_avrage_rating")]
        public float Rating { get; set; }
    }
}
