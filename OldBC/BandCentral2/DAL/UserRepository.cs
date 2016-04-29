using System;
using System.Collections.Generic;
using BandCentral.Models;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace BandCentral.DAL
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private BandCentralContext context;
        public UserRepository(BandCentralContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetUserByID(int userID)
        {
            return context.Users.Find(userID);
        }

        public void InsertUser(User user)
        {
            context.Users.Add(user);
        }

        public void DeleteUser(int userID)
        {
            User user = context.Users.Find(userID);
            context.Users.Remove(user);
        }
        public void UpdateUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}