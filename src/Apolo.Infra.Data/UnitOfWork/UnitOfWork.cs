using System;
using Apolo.Domain.Interfaces;
using Apolo.Infra.Data.Context;
using Apolo.Infra.Data.Repositories;

namespace Apolo.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private ISongRepository songRespository;
        private IUserRepository userRespository;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public ISongRepository SongRepository
        {
            get
            {
                if (songRespository == null)
                    songRespository = new SongRepository(_context);

                return songRespository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if(userRespository == null)
                    userRespository = new UserRepository(_context);
                return userRespository;
            }
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Commit();
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}