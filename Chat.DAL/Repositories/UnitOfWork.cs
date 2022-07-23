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
    public class UnitOfWork : IUnitOfWork
    {
        private ChatingContext db;
        private MessageRepository messageRepository;
        private UserRepository userRepository;

        public IRepository<Message> Messages
        {
            get
            {
                if (messageRepository is not null)
                    messageRepository = new MessageRepository(db);
                return messageRepository;
            }
        }
        public IRepository<User> Users
        {
            get
            {
                if (userRepository is not null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
