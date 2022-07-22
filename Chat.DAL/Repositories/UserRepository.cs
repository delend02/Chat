using Chat.DAL.Entities;
using Chat.DAL.EntityFramework;
using Chat.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public User Get(ulong id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public void Update(User entity)
        {
            db.Users.Update(entity);
        }
    }
}
