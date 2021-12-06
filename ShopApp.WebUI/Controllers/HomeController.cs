using Microsoft.AspNetCore.Mvc;
using ShopApp.data.Abstract;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.entity;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
     
        private IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            string mesaj = saat > 12 ? "İyi Günler" : "Günaydın";

            ViewBag.Greeting = mesaj;
            ViewBag.UserName = "Ahmet";

            var productViewModel = new ProductListViewModel()
            {
                Products = _productRepository.GetAll()
            };

            // View içerisine gönderilen string View->Home-> klasörü içerisinde NotIndex.cshtml sayfasını arıyor.
            return View(productViewModel);
        }

    }
}
