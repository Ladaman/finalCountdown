using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsScore.Models;
using SportsScore.Repositories.Interfaces;
using static SportsScore.Repositories.ProductsCollection;

namespace SportsScore.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void Add(Product productInfo)
        {
            var lastIndex = GetProducts()?.Last()?.ProductID ?? 0;

            products.Add(new Product
            {
                ProductID = ++lastIndex,
                Name = productInfo.Name,
                Price = productInfo.Price,
                Description = productInfo.Description,
                Category = productInfo.Category
            });
        }

        public bool Delete(int productId)
        {
            if (productId < 1)
            {
                return false;
            }

            var product = products.FirstOrDefault(x => x.ProductID == productId);

            if (product == null)
            {
                return false;
            }

            products.Remove(product);

            return true;
        }

    }
}
