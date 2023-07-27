namespace DemoProject.Data;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAll();

    Task<T> GetById(int id);

    Task<T> Create(T entity);

    Task<T> Update(T entity);

    Task Delete(T entity);
}