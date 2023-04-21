using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using ElectronicsShop.Data.Contexts;
using ElectronicsShop.Domain.Entities;
using ElectronicsShop.Helpers;

namespace ElectronicsShop.Data.Repositories
{
    public class UserRepository
    {
        private readonly ShopDbContext _dbContext;

        public UserRepository(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddUser(User user)
        {
            try
            {
                user.PasswordHash = PasswordHasher.HashPassword(user.PasswordHash);
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);

                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
        public User GetUserByUsername(string username)
        {
            return _dbContext.Users.SingleOrDefault(u => u.UserName == username);
        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.SingleOrDefault(u => u.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}
