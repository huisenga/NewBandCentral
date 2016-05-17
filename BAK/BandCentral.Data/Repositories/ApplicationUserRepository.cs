using BandCentral.Data.Infrastructure;
using BandCentral.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandCentral.Data.Repositories
{
    public class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserUserRepository
    {
        public ApplicationUserRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IApplicationUserUserRepository : IRepository<ApplicationUser>
    {

    }
}
