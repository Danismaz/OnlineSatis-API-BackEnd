using AutoMapper;
using DataTransfer.Concrete;
using KYSProjectApi.Models;

namespace KYSProjectApi.AutoMapper
{
    public class UserUIMapping : Profile
    {
        public UserUIMapping()
        {
            CreateMap<LoginDto,LoginVm>().ReverseMap();
            CreateMap<UserForRegisterVm,UserForRegisterModel>().ReverseMap();
            CreateMap<UserForChangePasswordDto, UserForChangePasswordVm>().ReverseMap();

            CreateMap<ContactUsDto, ContactUsVm>().ReverseMap();
        }
    }
}
