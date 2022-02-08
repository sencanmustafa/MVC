using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.webui.Models;

namespace shopapp.webui.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1,Name="Iphone 7",Price=3000,Description="Iphone 7",ImageUrl="1.jpg",CategoryId=1},
                new Product {ProductId = 2,Name="Iphone 8",Price=4000,Description="Iphone 8",ImageUrl="2.jpg",CategoryId=1},
                new Product {ProductId = 3,Name="Iphone X",Price=5000,Description="Iphone X",ImageUrl="3.jpg",CategoryId=2},
                new Product {ProductId = 4,Name="Iphone 11",Price=7000,Description="Iphone 11",ImageUrl="4.jpg",CategoryId=2}
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }


        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
        
        //void olması geriye bir değer döndürmediği anlamına geliyor sadece değişiklik yapar

        //parametre olarak Product sınıfından bir product alır
        public static void EditProduct(Product product)
        {
            //Product sınıfındakı tum ozellıklerı gezer(name,ıd vs)
            foreach (var p in _products)
            {
                //eger itemin ıd si dışarıdan gelen product daki id ye eşit ise değişiklikler yapılır
                if (p.ProductId == product.ProductId)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.CategoryId = product.CategoryId;
                    p.Description = product.Description;
                    p.ImageUrl = product.ImageUrl;
                }
            }
        }

        public static void Delete(int id)
        {
            var product = GetProductById(id);
            if(product!=null)
            {
                _products.Remove(product);
            }
        }

    }
}