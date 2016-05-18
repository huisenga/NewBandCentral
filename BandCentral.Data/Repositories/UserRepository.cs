using BandCentral.Data.Infrastructure;
using BandCentral.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandCentral.Data.Repositories
{
    public class UserRepository : RepositoryBase<ApplicationUser>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IUserRepository : IRepository<ApplicationUser>
    {

    }
}
