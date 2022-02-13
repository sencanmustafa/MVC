using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    //Irepository interfacesinden genel bi sanal sınıf ürettik ve product ve category lerde onu baz aldık ve generic içine category bılgısını yolladık
    //Bu işlevle Ireposıtory ıcındekı tum metodlara sahıp oalcak ve Irepo dakı T gordugu yere otomatıkmen Category yazmış olacak
    public interface ICategoryRepository:IRepository<Category>
    {
        //sadece categorye ozel
        List<Category> GetPopularCategories();
    }
}