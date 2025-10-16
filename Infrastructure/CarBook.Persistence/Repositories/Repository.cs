using CarBook.Application.Interfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CarBookDbContext _carBookDbContext = new CarBookDbContext();
        public Repository(CarBookDbContext carBookDbContext)
        {
            _carBookDbContext = carBookDbContext;
        }
        public async Task CreateAsync(T entity)
        {
            _carBookDbContext.Set<T>().Add(entity);
            await _carBookDbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _carBookDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _carBookDbContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _carBookDbContext.Set<T>().Remove(entity);
            await _carBookDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _carBookDbContext.Set<T>().Update(entity);
            await _carBookDbContext.SaveChangesAsync();
        }
    }
}
