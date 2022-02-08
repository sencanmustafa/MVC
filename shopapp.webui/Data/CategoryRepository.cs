using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Data
{
    public class CategoryRepository
    {
        //private null category list
        private static List<Category> _categories = null;
        
        
        //Constructor
        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1,Name="Telefonlar",Description="Telefon Kategorisi"},
                new Category {CategoryId=2,Name="Bilgisayar",Description="Bilgisayar Kategorisi"},
                new Category {CategoryId=3,Name="Tabletler",Description="Tablet Kategorisi"}
            };
        }
    

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    
        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }
    
        public static Category GetCategoryById(int id )
        {
            return _categories.FirstOrDefault(c=>c.CategoryId == id);
        } 
    
    
    
    
    
    }
}