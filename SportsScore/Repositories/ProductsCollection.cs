using SportsScore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsScore.Repositories
{
    public static class ProductsCollection
    {
        public static List<Product> products = new List<Product> {
            new Product{ProductID=1, Name="Cola", Price=2, Description="null", Category="Drinks"},
            new Product{ProductID=2, Name="Pepsi", Price=1, Description="null", Category="Drinks"},
            new Product{ProductID=3, Name="rc-cola", Price=50, Description="null",  Category="Drinks"},
            new Product{ProductID=4, Name="chocolate", Price=3, Description="null",  Category="Food"},
            new Product{ProductID=5, Name="Candy", Price=3, Description="null",  Category="Food"},
            new Product{ProductID=6, Name="Burger", Price=3, Description="null",  Category="Food"},
            new Product{ProductID=7, Name="kinder", Price=3, Description="null",  Category="Food"},
            new Product{ProductID=8, Name="Burger", Price=3, Description="null",  Category="Food"},
            new Product{ProductID=9, Name="Candy", Price=3, Description="null",  Category="Food"},
            new Product{ProductID=10, Name="Burger-menu", Price=43, Description="null",  Category="mc"},
            new Product{ProductID=11, Name="cheese", Price=3, Description="null",  Category="Food"},
            new Product{ProductID=12, Name="Burger", Price=3, Description="null",  Category="Food"},
            new Product{ProductID=13, Name="boots", Price=300, Description="null",  Category="clothes"},
            new Product{ProductID=14, Name="Burger", Price=3, Description="null",  Category="Food"}
            };
    }
}
