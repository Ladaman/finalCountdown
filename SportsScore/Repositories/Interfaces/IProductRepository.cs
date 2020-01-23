using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsScore.Models;

namespace SportsScore.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void Add(Product productInfo);
        bool Delete(int productId);
    }
}
