using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DataAccess.Data.Contexts;
using Demo.DataAccess.Models.DepartmentModel;
using Demo.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo.DataAccess.Repositories.Clasess
{
    public class GenericRepository<TEntity>(ApplicationDbContext _dbContext):IGenericRepository<TEntity> where TEntity : BaseEntity
    {
       

        //CRUD OPERATIONS

        // Get all
        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            {
                if (WithTracking)
                    return _dbContext.Set<TEntity>().ToList();
                else return _dbContext.Set<TEntity>().AsNoTracking().ToList();
            }
        }

        //Get By ID
        public TEntity? GetById(int id) => _dbContext.Set<TEntity>().Find(id);
        //update
        public int Update(TEntity entity)
        {
            {
                _dbContext.Set<TEntity>().Update(entity);
                return _dbContext.SaveChanges();
            }
        }
        //Delete
        public int Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return _dbContext.SaveChanges();
        }
        //insert
        public int Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return _dbContext.SaveChanges();
        }
    }
}

