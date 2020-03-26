using Apolo.Domain.Interfaces;
using Apolo.Domain.Models;
using Apolo.Infra.Data.Context;

namespace Apolo.Infra.Data.Repositories
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
            
        }
    }
}