using AutoMapper;
using BlogApi.BLL.Interfaces;
using BlogApi.DAL.Entities;
using BlogApi.DAL.IRepositories;
using BlogApi.Models;
using System.Runtime.CompilerServices;

namespace BlogApi.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserModel>> GetAllUser()
        {
            List<User> Users = (List<User>)await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserModel>>(Users);
        }

        //public Task<IEnumerable<UserModel>> GetAllUser()
        //{
        //    throw new NotImplementedException();
        //}


        //public Task AddAsync(UserModel payload)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task DeleteAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<UserModel> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateAsync(UserModel payload)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
