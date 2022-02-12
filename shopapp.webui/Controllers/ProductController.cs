using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shopapp.data;
using shopapp.entity;


namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult index()
        {

            return View();
        }


        //this input parameter is => navbar.cshtml/form/name=> input
        public IActionResult list(int? id, string input, double? min_price, double? max_price)
        {

            

            // var products = ProductRepository.Products;
            // if (id != null)
            // {
            //     products = products.Where(p => p.CategoryId == id).ToList();
               
            // }

            // //if input in not null => 
            // if (!string.IsNullOrEmpty(input))
            // {

            //     //search input layout if contains name or description in products
            //     products = products.Where(i => i.Name.ToLower().Contains(input.ToLower()) || i.Description.Contains(input)).ToList();
                
            // }
            
           


            // var productViewModel = new ProductViewModel()
            // {

            //     Products = products
            // };



            // return View(productViewModel);
            return View();
        }


        
        
        [HttpGet]
        //Create sayfası ilk açıldıgında bu metot get request oldugu ıcın burası calısır submıt ettıgımızde ıse alttakı post request metodu calısır
        
        
        public IActionResult create()
        {   
            //select list metodu ıle aşırı yuklenmıs 3. metodu kullanarak  data valuenın nereye ilişkilendirileceği , ve data text field in nereye ilişkilendirileceğini belirledik
            
            // ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            
            //Get ıle sayfayı ılk cagırdıgımız ıcın Buraya bir tane Product referansı tanımlamamız gerekıyor(Post da parametre olarak alıyıoruz burda almıyoruz) yoksa Nullreferance hatası alırız validationdan Product objesı olmadan gecemez 
            return View(new Product());
        }

        
        //Get request standart olarak Iaction resultlarda bulunur ancak post ıcın bunu ozel olarak eklememız gerkekıyor

        [HttpPost]

        //Parametre olarak tek tek değişken tanımlayabılırdık ancak bunun yerıne Product sınıfından herhangi bir nesne uretıp bunun uzerınden ulaşabılırız.

        public IActionResult create(Product p)
        {
            //Add list to form values 
            //ProductRepository.add

            //model state methodu Produt sınıfndakı validation(required vs) bilgilerini tutar!!
            //Model.state=> is.valide?? (kurallardan onay almış mı?)
            // if(ModelState.IsValid)
            // {
            //     ProductRepository.AddProduct(p);
            //     //return redirec list pages
            //     return RedirectToAction("list"); 
            // }
            // else
            // {
            //     return View(p);
            // }
            return View();
            
            
            
              
        }


        [HttpGet]
        public IActionResult edit(int id)
        {
            //Category formundakı categoryId bılgısnın gelmesı ıcın bu satır gereklı
             //ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            
            //Burda edit.cshtml sayfasının route ettıgı id parametreye gelır ve repositorydekı getById fonksiyonundan bir product'ı id ye baglı 
            //return eder ve bu product edit.cshtml ustundekı @model Product daki Product yerine geçer ve formlara yerleşir.
            return View();
        }

        [HttpPost]
        public IActionResult edit(Product p)
        {
            //ProductRepository.EditProduct(p);
            return RedirectToAction("list");
        }

        [HttpPost]
        public IActionResult delete(int ProductId)
        {
            //ProductRepository.Delete(ProductId);
            return RedirectToAction("list");
           
        }

        
    }


}