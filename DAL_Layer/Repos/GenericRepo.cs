using DAL_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer 
{ 
    public class GenericRepo<T> : IGenericDal<T> where T : class
    {
        Context context= new Context();

        DbSet<T> _object;
        public GenericRepo()
        {
            _object=context.Set<T>();
        }
        //--------------------------------------------
        public void Delete(T item)
        {
            var deletedEntity=context.Entry(item);
            deletedEntity.State = EntityState.Deleted;

            //_object.Remove(item);

            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T item)
        {
            var addedEntity = context.Entry(item);
            addedEntity.State=EntityState.Added;
            
            //_object.Add(item);

            context.SaveChanges();
        }

        public void Update(T item)
        {
            var updatedEntity = context.Entry(item);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
