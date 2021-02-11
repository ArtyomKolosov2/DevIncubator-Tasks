using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Data
{
    public interface IRepository<T> where T: IEntity
    {
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        T GetByIdOrDefault(int id);
    }
}
