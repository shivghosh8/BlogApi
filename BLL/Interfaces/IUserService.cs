using BlogApi.DAL.Entities;
using BlogApi.Models;

namespace BlogApi.BLL.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<List<UserModel>>> GetAllUser();
        //Task<UserModel> GetByIdAsync(int id);
        //Task AddAsync(UserModel payload);
        //Task UpdateAsync(UserModel payload);
        //Task DeleteAsync(int id);
    }
}
