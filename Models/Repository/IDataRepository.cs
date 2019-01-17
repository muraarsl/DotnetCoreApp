using CoreSample.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoreSample.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(User User, TEntity entity);
        void Delete(User User);
    }

    public class UserManager : IDataRepository<User>
    {
        readonly IntertechContext _intertechContext;
 
        public UserManager(IntertechContext context)
        {
            _intertechContext = context;
        }
 
        public IEnumerable<User> GetAll()
        {
            return _intertechContext.Users.ToList();
        }
 
        public User Get(long id)
        {
            return _intertechContext.Users
                  .FirstOrDefault(e => e.Id == id);
        }
 
        public void Add(User entity)
        {
            _intertechContext.Users.Add(entity);
            _intertechContext.SaveChanges();
        }
 
        public void Update(User User, User entity)
        {
            // User.FirstName = entity.FirstName;
            // User.LastName = entity.LastName;
            // User.Email = entity.Email;
            // User.DateOfBirth = entity.DateOfBirth;
            // User.PhoneNumber = entity.PhoneNumber;
 
            _intertechContext.SaveChanges();
        }
 
        public void Delete(User User)
        {
            _intertechContext.Users.Remove(User);
            _intertechContext.SaveChanges();
        }
    }

}