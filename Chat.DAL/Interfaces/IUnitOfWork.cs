using Chat.DAL.Entities;

namespace Chat.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Message> Messages { get; }
        IRepository<User> Users { get; }
        void Save();
    }
}
