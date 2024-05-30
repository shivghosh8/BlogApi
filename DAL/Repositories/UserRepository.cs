using BlogApi.DAL.Entities;
using BlogApi.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.DAL.Repositories
{
    public class UserRepository : Repository<User, BlogDbContext>, IUserRepository
    {


        public UserRepository(BlogDbContext context) : base(context)
        {

        }

    }
}
