using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsScore.Models
{
    public class ProductsList
    {
        public IEnumerable<Product> Products { get; set; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        public int CurrentPageIndex { get; set; }
    }
}
