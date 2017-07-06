using System.Collections.Generic;
using blogResearchNetCore.Models;

namespace blogResearchNetCore.Service
{
    public interface IService{

    }

    public interface IEntityService<T>: IService where T :BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();      
        void Update(T entity);
    }
}