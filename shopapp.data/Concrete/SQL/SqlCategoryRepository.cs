// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using shopapp.data.Abstract;
// using shopapp.entity;

// namespace shopapp.data.Concrete.SQL
// {
//     public class SqlCategoryRepository : ICategoryRepository
//     {
//         private ShopContext db = new ShopContext();
//         public void Create(Category entity)
//         {
//             db.Categories.Add(entity);
//             db.SaveChanges();
//         }

    
//         public void Delete(Category entity)
//         {
//             throw new NotImplementedException();
//         }

//         public List<Category> GetAll()
//         {
//             throw new NotImplementedException();
//         }

//         public Category GetById(int id)
//         {
//             throw new NotImplementedException();
//         }

//         public List<Category> GetPopularCategories()
//         {
//             throw new NotImplementedException();
//         }

//         public void Update(Category entity)
//         {
//             throw new NotImplementedException();
//         }
//     }
// }