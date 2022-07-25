namespace Chat.DAL.Interfaces
{
    public interface IRepository<T> 
        where T : class
    {
        IEnumerable<T> GetAll();
        T Get(ulong id);
        T FindByKey(Func<T, Boolean> predicate);
        void Create(T entity);
        void Update(T entity);
        IEnumerable<T> GetLast();
        void Delete(ulong id);
    }
}
