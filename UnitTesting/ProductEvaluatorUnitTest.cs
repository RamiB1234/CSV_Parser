using CSV_Parser.Infrastructure;
using CSV_Parser.Models.Entities;
using System.Collections.Generic;
using Xunit;

namespace UnitTesting
{
    public class ProductEvaluatorUnitTest
    {
        [Fact]
        public void TestEvaluate()
        {
            // 1. Arrange
            var products = GenerateTestProducts();

            // 2. Act 
            var topProd = ProductEvaluator.Evaluate(products);

            // 3. Assert 
            Assert.Equal("High rating prod", topProd.ProductName);
        }


        List<Product> GenerateTestProducts()
        {
            var prod1 = new Product
            {
                Id = 1,
                ProductName = "Low rating prod",
                Rating = 2.4f
            };

            var prod2 = new Product
            {
                Id = 2,
                ProductName = "High rating prod",
                Rating = 4.85f
            };

            var products = new List<Product>();
            products.Add(prod1);
            products.Add(prod2);

            return products;
        }
    }
}
