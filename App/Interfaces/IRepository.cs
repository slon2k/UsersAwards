using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public T Add(T item);
        public void Update(T item);
        public void Delete(T item);
    }
}
