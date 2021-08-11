using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_BAL.Interface;
using CRUD_DAL.Interface;
using CRUD_DAL.Entities;

namespace CRUD_BAL.Service
{
    public class Service<T> : IService<T> where T : class, IEntity
    {
        private readonly IRepository<T> _repository;
        public Service(IRepository<T> repository) => _repository = repository;

        public T GetByIdAsync(int id)
        {
            var @object = _repository.GetById(id);

            return @object;
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            var query = _repository.GetAll();

            return Task.FromResult(query.AsEnumerable());
        }

        public async Task<T> AddAsync(T @object)
        {
            var result = _repository.Create(@object);

            await _repository.SaveAsync();

            return Task.FromResult(result).Result;
        }

        public void Delete(T @object)
        {
            _repository.Delete(@object);

            _repository.Save();
        }

        public void Update(T @object)
        {
            _repository.Update(@object);
            _repository.Save();
        }
    }
}

