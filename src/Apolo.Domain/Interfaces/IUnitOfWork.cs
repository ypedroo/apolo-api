using System;

namespace Apolo.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository userRepository { get; }
        ISongRepository songRepository { get; }
        //: each repository
        int Commit();
    }
}