using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity, int id);
        Task<bool> Remove(int id);
    }
}
