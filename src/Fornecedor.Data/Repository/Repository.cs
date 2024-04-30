using Fornecedor.Business.Interfaces;
using Fornecedor.Business.Models;
using Fornecedor.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Fornecedor.Data.Repository {
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity {

        protected readonly DataContext Data;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(DataContext data) {
            Data = data;
            DbSet = data.Set<TEntity>();
        }
        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate) {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id) {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll() {
            return await DbSet.ToListAsync();
        }

        public async Task Add(TEntity entity) {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Update(TEntity entity) {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public async Task Delete(Guid id) {
            DbSet.Remove(await DbSet.FindAsync(id));
            await SaveChanges();
        }

        public void Dispose() {
            Data?.Dispose();
        }

        public async Task<int> SaveChanges() { 
            return await Data.SaveChangesAsync();
        }
    }
}
