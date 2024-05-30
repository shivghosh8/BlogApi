using System.Linq.Expressions;

namespace BlogApi.DAL.IRepositories
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAllByCondition(Expression<Func<T, bool>> condition);
        Task<ICollection<T>> GetAllByConditionAsync(Expression<Func<T, bool>> condition);

        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsync();

        T GetSingle(Expression<Func<T, bool>> condition);

        Task<T> GetSingleAysnc(Expression<Func<T, bool>> condition);

        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        void SaveChangesManaged();
    }
}
