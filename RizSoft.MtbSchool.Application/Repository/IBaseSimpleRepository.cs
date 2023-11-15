﻿namespace RizSoft.MtbSchool.Application;

public interface IBaseSimpleRepository<T, in TKey> 
{
    Task<T> GetAsync(TKey id);
    Task<List<T>> ListAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteAsync(TKey id);
}

