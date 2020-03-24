using System;
using System.Collections.Generic;
using Apolo.Domain.Core.Models;

namespace Apolo.Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        List<T> GetAll();
    }
}