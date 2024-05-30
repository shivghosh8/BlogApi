using BlogApi.DAL.Entities;
using BlogApi.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using static BlogApi.DAL.IRepositories.IPostRepository;

namespace BlogApi.DAL.Repositories
{
    public class PostRepository : Repository<Post, BlogDbContext>, IPostRepository
    {


        public PostRepository(BlogDbContext context) : base(context)
        {

        }


    }
}
