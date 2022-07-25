using Chat.DAL.Entities;
using Chat.DAL.EntityFramework;
using Chat.DAL.Interfaces;

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

        public Message FindByKey(Func<Message, bool> predicate)
        {
            return db.Messages.Find(predicate);
        }

        public Message Get(ulong id)
        {
            return db.Messages.Find(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return db.Messages;
        }

        public IEnumerable<Message> GetLast()
        {
            return db.Messages.Take(200);
        }

        public void Update(Message entity)
        {
            db.Messages.Update(entity);
        }
    }
}
