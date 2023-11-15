namespace RizSoft.MtbSchool.Application;

public interface IQueryBaseRepository<out T>
{
     IQueryable<T> Query { get; }

}