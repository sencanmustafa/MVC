using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;

namespace shopapp.data.Concrete.SQL
{
    public class SqlGenericRepository<TEntity, TContext> : IRepository<TEntity>
        //TEntity ve TContext in sınıf oldugu bilgisi ve new lenebilir
        //TContext vgeneric bi dtabase Produdct veya Category nın hangısı oldugu gelen verıye gore otomatık olusacak Irepository gibi
        //TEntity generic bi veri olacak category mı product mı oldugu gelen verıye gole otomatık olusacak
        where TEntity : class
        where TContext : DbContext,new()
    {
        public void Create(TEntity entity)
        {
            using(var context = new TContext())
            {
                //Burada Contextin içeriğini  product mı yoksa category mı oldugunu bılmıyoruz o yuzde .Set metodunu kullanarak Tentity veriyoruz (gelen verı otomatık Pro veya category e donecegı ıcın ) sonra onu add metodu ile dbaseye(context ıse => new TCOntext=> product mı yoksa category dbsesı mı bellı deıl aynı mantık) ye eklıyoruz 
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            } 
        }

        public void Delete(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using(var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using(var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            using(var context = new TContext())
            {
                //Entity nin değiştirilen statesi modified edilmiş olacak 
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}