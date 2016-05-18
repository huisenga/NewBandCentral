using BandCentral;
using BandCentral.Data.Infrastructure;
using BandCentral.Data.Repositories;
using BandCentral.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace BandCentral.Service
{
    public interface IBandService
    {
        IEnumerable<Band> GetBands();
        Band GetBand(int ID);
        void CreateBand(Band band);
        void SaveBand();
        void DeleteBand(int ID);
        void UpdateBand(Band band);
        void AddUserBand(Band band, ApplicationUser user);
        void RemoveUserBand(Band band, ApplicationUser user);
    }

    public class BandService : IBandService
    {
        private readonly IBandRepository bandsRepository;
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public BandService(IBandRepository bandsRepository, IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.bandsRepository = bandsRepository;
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }
        #region IBandService Members

        public IEnumerable<Band> GetBands()
        {
            var bands = bandsRepository.GetAll();
            return bands;
        }

        public Band GetBand(int id)
        {
            var band = bandsRepository.GetById(id);
            return band;
        }

        public void CreateBand(Band band)
        {
            bandsRepository.Add(band);
        }

        public void DeleteBand(int id)
        {
            var band = bandsRepository.GetById(id);
            bandsRepository.Delete(band);
        }

        public void UpdateBand(Band band)
        {
            bandsRepository.Update(band);
        }
        public void AddUserBand(Band band, ApplicationUser user)
        {
            band.Users.Add(user);
            bandsRepository.Update(band);
        }
        public void RemoveUserBand(Band band, ApplicationUser user)
        {
            band.Users.Remove(user);
            bandsRepository.Update(band);
        }
        public void SaveBand()
        {
            unitOfWork.Commit();
        }

        

        #endregion

    }
}
