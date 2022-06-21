using DotNet_DataTransfer_ToView.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNet_DataTransfer_ToView.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> GetProductList { 
            get 
            {

                List<Product> products = new List<Product>();
                
                products.Add(new Product { Id = 1, ProductName = "Elma", Price = 20, Stock = 10 });
                products.Add(new Product { Id = 2, ProductName = "Armut", Price = 15, Stock = 8 });
                products.Add(new Product { Id = 3, ProductName = "Vişne", Price = 10, Stock = 20 });
                products.Add(new Product { Id = 4, ProductName = "Kayısı", Price = 5, Stock = 15 });

                return products;

            } 
        }

        public IActionResult List()
        {
            TempData["ProductList"] = JsonConvert.SerializeObject(GetProductList);
            ViewBag.ProductList = JsonConvert.SerializeObject(GetProductList);
            ViewData["ProductList"] = JsonConvert.SerializeObject(GetProductList);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var tempDataVeri = TempData["ProductList"];
            var viewBagDataVeri = ViewBag.ProductList;
            var viewDataVeri = ViewData["ProductList"];

            return View();
        }
    }
}
