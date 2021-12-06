using Microsoft.AspNetCore.Mvc;
using ShopApp.data.Abstract;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IProductRepository _productRepository;
        public ShopController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IActionResult List()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productRepository.GetAll()
            };

            return View(productViewModel);
        }

    }
}
