using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Repository
{
    //using pattern repository
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> All { get; }
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity FindById(int Id);
        TEntity FindById(string Id);
    }
}
