using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_DAL.Entities;

namespace CRUD_BAL.Interface
{
    public interface IService<T>
    {
        public T GetByIdAsync(int userId);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> AddAsync(T person);
        public void Delete(T person);
        public void Update(T person);
    }
}
