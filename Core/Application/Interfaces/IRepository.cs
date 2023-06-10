namespace Application.Interfaces
{
    public interface IRepository<T>
    {
        Task<string> AddAsync(T entity);
    }
}
