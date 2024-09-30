using AutoMapper;
using DataTransfer.Concrete;
using KYSProjectApi.Models;

namespace KYSProjectApi.AutoMapper
{
    public class UserUiMapping : Profile
    {
        public UserUiMapping()
        {
            CreateMap<LoginDto,LoginVm>().ReverseMap();
            CreateMap<UserForRegisterVm,UserForRegisterDto>().ReverseMap();
            CreateMap<UserForRegisterVm,UserForRegisterModel>().ReverseMap();
            CreateMap<UserForChangePasswordDto, UserForChangePasswordVm>().ReverseMap();

            CreateMap<ContactUsDto, ContactUsVm>().ReverseMap();
        }
    }
}
