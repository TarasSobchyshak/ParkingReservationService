using AutoMapper;
using PRS.Business.Models;

namespace PRS.Business.Infrastructure.ProfileMappers
{
    public class UserProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<User, UserModel>();

            CreateMap<UserModel, User>();
        }
    }
}
