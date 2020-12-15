using CSV_Parser.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CSV_Parser.Infrastructure
{
    public static class ProductEvaluator
    {
        public static Product Evaluate(List<Product> products)
        {
            var orderedProducts = products.OrderByDescending(x => x.Rating);
            return orderedProducts.ElementAt(0);
        }
    }
}
