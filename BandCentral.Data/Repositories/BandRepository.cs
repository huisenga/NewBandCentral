using BandCentral.Data.Infrastructure;
using BandCentral.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandCentral.Data.Repositories
{
    public class BandRepository: RepositoryBase<Band>, IBandRepository
    {
        public BandRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
    public interface IBandRepository: IRepository<Band>
    {

    }
}
