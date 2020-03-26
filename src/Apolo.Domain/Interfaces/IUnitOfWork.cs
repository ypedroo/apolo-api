using System;

namespace Apolo.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        ISongRepository SongRepository { get; }
        int Commit();
    }
}