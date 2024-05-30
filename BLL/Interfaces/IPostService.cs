using BlogApi.DAL.Entities;

namespace BlogApi.BLL.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllPost();
        Task<Post> GetByIdPost(int id);
        Task AddPost(Post post);
        Task UpdatePost(Post post);
        Task DeletePost(int id);
    }
}
