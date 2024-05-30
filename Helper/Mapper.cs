using AutoMapper;
using BlogApi.DAL.Entities;
using BlogApi.Models;

namespace BlogApi.Helper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<PostModel, Post>().ReverseMap();
            CreateMap<UserModel, User>().ReverseMap();
        }

    }
}
