using System;

namespace Apolo.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //each repository
        int Commit();
    }
}