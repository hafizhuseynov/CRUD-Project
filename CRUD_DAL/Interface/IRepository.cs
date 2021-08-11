using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_DAL.Entities;

namespace CRUD_DAL.Interface
{
    public interface IRepository<T> where T : class, IEntity
    {
        public T Create(T @object);
        public void Update(T @object);
        public IQueryable<T> GetAll();
        public T GetById(int id);
        public void Delete(T @object);
        public void Save();
        public Task SaveAsync();
    }
}
