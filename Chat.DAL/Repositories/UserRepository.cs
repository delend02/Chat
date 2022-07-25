using Chat.DAL.Entities;
using Chat.DAL.EntityFramework;
using Chat.DAL.Interfaces;

namespace Chat.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private ChatingContext db;

        public UserRepository(ChatingContext db)
        {
            this.db = db;
        }

        public void Create(User entity)
        {
            db.Users.Add(entity);
        }

        public void Delete(ulong id)
        {
            var user = db.Users.Find(id);
            if (user is not null)
                db.Users.Remove(user);
        }

        public User FindByKey(Func<User, bool> predicate)
        {
            return db.Users.Find(predicate);
        }

        public User Get(ulong id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public IEnumerable<User> GetLast()
        {
            return db.Users.Take(15);
        }

        public void Update(User entity)
        {
            db.Users.Update(entity);
        }
    }
}
