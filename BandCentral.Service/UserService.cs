using BandCentral.Data.Infrastructure;
using BandCentral.Data.Repositories;
using BandCentral.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandCentral.Service
{
    public interface IUserService
    {
        ApplicationUser GetUser(string ID);
    }

    public class UserService : IUserService
    {
        /* NOTE: The origianl design of this site did not include a service for users, opting instead to use only the application user manager.
        Operations including both Users and Bands did not work however due to ApplicationUserManager and BandService using different dbContexts.
        If development continued on this project, this service would be flushed out, and Identity would only be used for authorization mechanics.*/
        private readonly IUserRepository userRepository;
        private readonly IBandRepository bandRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork, IBandRepository bandRepository)
        {
            this.userRepository = userRepository;
            this.bandRepository = bandRepository;
            this.unitOfWork = unitOfWork;
        }
        #region IBandService Members

        public ApplicationUser GetUser(string ID)
        {
            var user = userRepository.GetById(ID);
            return user;
        }
        #endregion
    }
}
