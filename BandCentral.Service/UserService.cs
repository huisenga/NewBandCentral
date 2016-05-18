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
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
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
