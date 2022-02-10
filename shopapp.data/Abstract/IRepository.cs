using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.data.Abstract
{
    //Irepository interfacesinden genel bi sanal sınıf ürettik ve product ve category lerde onu baz aldık ve generic içine Product bılgısını yolladık
    //Bu işlevle Ireposıtory ıcındekı tum metodlara sahıp oalcak ve Irepo dakı T gordugu yere otomatıkmen Product yazmış olacak
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}