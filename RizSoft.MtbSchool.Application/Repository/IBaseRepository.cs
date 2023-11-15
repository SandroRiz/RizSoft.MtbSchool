namespace RizSoft.MtbSchool.Application;

public interface IBaseRepository<T, in TKey> //: IQueryBaseRepository<T>
{
    Task<T> GetAsync(TKey id);
    Task<List<T>> ListAsync();
    Task<List<T>> ListCurrentAsync(TKey id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteAsync(TKey id);
}

