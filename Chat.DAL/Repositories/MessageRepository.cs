using Chat.DAL.Entities;
using Chat.DAL.EntityFramework;
using Chat.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.DAL.Repositories
{
    public class MessageRepository : IRepository<Message>
    {
        private ChatingContext db;

        public MessageRepository(ChatingContext db)
        {
            this.db = db;
        }

        public void Create(Message entity)
        {
            db.Add(entity);
        }

        public void Delete(ulong id)
        {
            var message = db.Messages.Find(id);
            if (message is not null)
                db.Messages.Remove(message);
        }

        public Message Get(ulong id)
        {
            return db.Messages.Find(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return db.Messages;
        }

        public void Update(Message entity)
        {
            db.Messages.Update(entity);
        }
    }
}
