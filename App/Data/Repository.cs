using App.Entities;
using App.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private AppDbContext context;

        public Repository(AppDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public T Add(T item)
        {
            context.Set<T>().Add(item);
            context.SaveChanges();
            return item;
        }

        public void Delete(T item)
        {
            context.Set<T>().Remove(item);
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(T item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
