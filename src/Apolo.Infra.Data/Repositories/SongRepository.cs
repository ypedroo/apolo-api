using Apolo.Domain.Interfaces;
using Apolo.Domain.Models;
using Apolo.Infra.Data.Context;

namespace Apolo.Infra.Data.Repositories
{
    public class SongRepository : Repository<Songs>, ISongRepository
    {
        public SongRepository(DataContext context) : base(context)
        {            
        }
    }
}