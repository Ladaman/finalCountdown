using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsScore.Models;
using SportsScore.Models.Products;
using SportsScore.Repositories;
using SportsScore.Repositories.Interfaces;

namespace SportsScore.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index(int currentPageIndex, string sortOrder)
        {
            int pageSize = 5;

            ProductsList productsList = new ProductsList();
            IEnumerable<Product> products = productRepository.GetProducts();

            switch (sortOrder)
            {
                case "name":
                    products = products.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    products = products.OrderByDescending(s => s.Name);
                    break;
                case "price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.Category);
                    break;
            }

            productsList.Products = products.Skip(currentPageIndex * pageSize).Take(pageSize);
            productsList.TotalCount = products.Count();
            productsList.PageSize = pageSize;
            productsList.CurrentPageIndex = currentPageIndex;

            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name" : sortOrder == "name" ? "name_desc" : "name";
            ViewData["PriceSortParm"] = string.IsNullOrEmpty(sortOrder) ? "price" : sortOrder == "price" ? "price_desc" : "price";
            ViewData["CurrentSortParam"] = sortOrder ?? string.Empty;

            return View(productsList);
        }

        public IActionResult Add(AddProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            productRepository.Add(new Product
            {
                Name = model.Name,
                Price = model.Price,
                Description = model.Desc,
                Category = model.Category
            });

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var response = productRepository.Delete(id);

            return RedirectToAction("Index");
        }

        #region Temp

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
