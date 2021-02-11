using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Data
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _dataHolder = new List<T>();
        public IReadOnlyCollection<T> Data { get => _dataHolder; }
        public void Add(T entity)
        {
            _dataHolder.Add(entity);
        }

        public void Delete(int id)
        {
            var deleteElement = GetByIdOrDefault(id);
            if (deleteElement != null)
            {
                _dataHolder.Remove(deleteElement);
            }
        }

        public T GetByIdOrDefault(int id)
        {
            return _dataHolder.FirstOrDefault(entity => entity.Id == id);
        }

        public void Update(int id, T entity)
        {
            var replaceElement = GetByIdOrDefault(id);
            if (replaceElement != null)
            {
                var index = _dataHolder.IndexOf(replaceElement);
                _dataHolder[index] = entity;
            }

        }
    }
}
