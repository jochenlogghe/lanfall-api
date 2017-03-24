using LF.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LF.Repository
{
    public interface IGenericRepository<T> : IDisposable where T : Entity
    {
        Task<IQueryable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Insert(T entity);
        Task<T> Update(int id, T entity);
        Task<T> Delete(T entity);
        Task<bool> Exists(int id);
    }
}
