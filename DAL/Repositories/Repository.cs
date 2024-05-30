using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static BlogApi.DAL.IRepositories.IPostRepository;
using BlogApi.DAL.IRepositories;

namespace BlogApi.DAL.Repositories
{
    public class Repository<T, Tcontext> : IRepository<T> where T : class where Tcontext : BlogDbContext
    {
        protected readonly Tcontext BlogDbContext = null;

        public Repository(Tcontext context)
        {
            BlogDbContext = context;
        }


        public bool IsTransactionRunning()
        {
            return BlogDbContext.Database.CurrentTransaction == null ? false : true;
        }
        private IDbContextTransaction BeginTran()
        {
            return BlogDbContext.Database.BeginTransaction();
        }



        public IExecutionStrategy GetExecutionStrategy()
        {
            return BlogDbContext.Database.CreateExecutionStrategy();
        }


        public IQueryable<T> GetAllByCondition(Expression<Func<T, bool>> condition)
        {
            IQueryable<T> result = BlogDbContext.Set<T>();
            if (condition != null)
            {
                result = result.Where(condition);
            }

            return result;
        }

        public async Task<ICollection<T>> GetAllByConditionAsync(Expression<Func<T, bool>> condition)
        {
            IQueryable<T> result = BlogDbContext.Set<T>();
            if (condition != null)
            {
                result = result.Where(condition);
            }

            return await result.ToListAsync();
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> result = BlogDbContext.Set<T>();
            return result;
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            IQueryable<T> result = BlogDbContext.Set<T>();
            return await result.ToListAsync();
        }

        public T GetSingle(Expression<Func<T, bool>> condition)
        {
            return BlogDbContext.Set<T>().Where(condition).FirstOrDefault();
        }
        public async Task<T> GetSingleAysnc(Expression<Func<T, bool>> condition)
        {
            var retValue = await BlogDbContext.Set<T>().Where(condition).SingleOrDefaultAsync();

            return retValue;
        }



        public bool Add(T entity)
        {
            BlogDbContext.Set<T>().Add(entity);
            return true;
        }

        public bool Update(T entity)
        {
            BlogDbContext.Entry(entity).State = EntityState.Modified;
            return true;
        }

        public bool Delete(T entity)
        {
            BlogDbContext.Set<T>().Remove(entity);
            return true;
        }


        public void SaveChangesManaged()
        {
            BlogDbContext.SaveChanges();
        }

    }
}
