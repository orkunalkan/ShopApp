using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopApp.entity;
using ShopApp.data.Abstract;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public IActionResult Details(int id)
        {

            //return View(ProductRepository.GetProductById(id));
            return View();
        }


        public IActionResult List(int? id, string q)
        {

            //var products = ProductRepository.Products;

            //if (id != null)
            //{
            //    products = products.Where(p => p.CategoryId == id).ToList();
            //}

            //if (!string.IsNullOrEmpty(q))
            //{
            //    products = products.Where(i => i.name.Contains(q) || i.description.Contains(q)).ToList();
            //}

            //var productViewModel = new ProductViewModel()
            //{
            //    Products = products
            //};

            //return View(productViewModel);

            var productViewModel = new ProductListViewModel()
            {
                Products = _productRepository.GetAll()
            };
            return View(productViewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "name");

            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            //if (ModelState.IsValid)
            //{
            //    ProductRepository.AddProduct(product);
            //    return RedirectToAction("list");
            //}
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "name");
            return View();

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "name");

            //return View(ProductRepository.GetProductById(id));
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {

            //ProductRepository.EditProduct(product);

            return RedirectToAction("list");
        }
        [HttpPost]
        public IActionResult Delete(int ProductId)
        {

            //ProductRepository.DeleteProduct(ProductId);

            return RedirectToAction("list");
        }
    }
}
