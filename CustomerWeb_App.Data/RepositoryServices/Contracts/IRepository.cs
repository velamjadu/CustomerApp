using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWeb_App.Data.RepositoryServices.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(object id);
        int Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        int ExecuteNonQuery(string query, dynamic param = null, CommandType? commandType = null);
        IQueryable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}
