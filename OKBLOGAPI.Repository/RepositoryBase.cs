using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OKBLOGAPI.Domain;

namespace OKBLOGAPI.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        public OKBLOGContext _context { get; private set; }

        public DbSet<T> _dbSet { get; private set; }

        public RepositoryBase(OKBLOGContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        { 
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<T>> RetrieveAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> RetrieveAync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

    }
}

