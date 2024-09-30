using AutoMapper;
using Business.Sevices.Interfaces;
using KYSProjectApi.Services.TCKimlikService;
using KYSProjectApi.Services.Token;

namespace KYSProjectApi.Services.ControllerService
{
    public class AccountControllerServices
    {
        public IUserService UserService { get; }
        public ICryptographyProcessor Cryptography { get; }
        public ITokenService TokenService { get; }
        public IMapper Mapper { get; }
        public ITCKimlikService TcService { get; }
        public IEmailService EmailService { get; }
        public IUserDetailService UserDetailService { get; }

        public AccountControllerServices(
            IUserService userService,
            ICryptographyProcessor cryptography,
            ITokenService tokenService,
            IMapper mapper,
            ITCKimlikService tcService,
            IEmailService emailService,
            IUserDetailService userDetailService)
        {
            UserService = userService;
            Cryptography = cryptography;
            TokenService = tokenService;
            Mapper = mapper;
            TcService = tcService;
            EmailService = emailService;
            UserDetailService = userDetailService;
        }
    }
}
