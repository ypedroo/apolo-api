using System.Collections.Generic;
using System.Linq;
using Apolo.Domain.Core.Models;
using Apolo.Domain.Interfaces;
using Apolo.Infra.Data.Context;

namespace Apolo.Infra.Data
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}