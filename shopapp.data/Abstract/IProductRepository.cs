using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;


namespace shopapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        //Irepoya ait degıl sadece Product a aıt olur
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name);
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
    }
}