using CRUD_DAL.Data;
using CRUD_DAL.Interface;
using CRUD_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.Migrations.Migration;

namespace CRUD_DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<T> _db;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
            _db = _dbContext.Set<T>();
        }

        public T Create(T @object)
        {
            return _db.Add(@object).Entity;
        }

        public void Update(T @object)
        {
            _db.Update(@object);
        }

        public IQueryable<T> GetAll()
        {
            return _db.AsQueryable();
        }

        public T GetById(int id)
        {
            return _db.Find(id);
        }

        public void Delete(T @object)
        {
            _db.Remove(@object);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
