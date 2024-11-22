using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "IPhone X",
                    Category = "Smart Phone",
                    Description = "This is IPhone X",
                    Image = "product-1.png",
                    Price = 950.00M
                },
                new Product
                {
                    Name = "Samsung Galaxy S10",
                    Category = "Smart Phone",
                    Description = "This is Samsung Galaxy S10",
                    Image = "product-2.png",
                    Price = 900.00M
                },
                new Product
                {
                    Name = "Huawei P30 Pro",
                    Category = "Smart Phone",
                    Description = "This is Huawei P30 Pro",
                    Image = "product-3.png",
                    Price = 800.00M
                }
            };
        }
    }
}
