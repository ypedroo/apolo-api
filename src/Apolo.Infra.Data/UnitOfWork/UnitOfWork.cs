using System;
using Apolo.Infra.Data.Context;

namespace Apolo.Infra.Data.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly DataContext _context;
        // declare readonly repository here

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        //model to instiate repo from example code
        // public IBankAccountRepository AccountRepository
        // {
        //     get
        //     {
        //         if (accountRepository == null)
        //             accountRepository = new BankAccountRepository(_context);

        //         return accountRepository;
        //     }
        // }

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