using Fornecedor.Business.Models;
using System.Linq.Expressions;

namespace Fornecedor.Business.Interfaces {
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity {
        
        Task Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Delete(Guid id);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();


    }
}
