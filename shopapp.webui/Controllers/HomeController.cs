using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.data.Abstract;

namespace shopapp.webui.Controllers
{
    public class HomeController:Controller
    {
        
        private IProductRepository _productrepository;
        //constructor => cause of security of Repository
        public HomeController(IProductRepository productrepository)
        {
            this._productrepository = productrepository;
        }
        public IActionResult index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productrepository.GetAll()
            };
            return View(productViewModel);
        }

        public IActionResult about()
        {
            return View();
        }
    }
}