using Autofac;
using AutoMapper;
using Business.ActionFilters;
using DataAccess.Repositories.Interfaces;
using DataAccess.Repositories.Concrete;
using Business.Sevices.Interfaces;
using Business.Sevices.Concrete;
using KYSProjectApi.Services.Token;
using Business.AutoMapper;
using KYSProjectApi.Services.TCKimlikService;
using KYSProjectApi.AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Autofac;

public class AutofacApiModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(typeof(BaseRepository<>).Assembly).AsClosedTypesOf(typeof(IBaseRepository<>)).InstancePerLifetimeScope();
        builder.RegisterAssemblyTypes(typeof(BaseService<,>).Assembly).AsClosedTypesOf(typeof(IBaseService<,>)).InstancePerLifetimeScope();


        builder.RegisterType<TokenService>().As<ITokenService>().SingleInstance();

        builder.RegisterType<CryptographyProcessorRepo>().As<ICryptographyProcessorRepo>().InstancePerLifetimeScope();
        builder.RegisterType<CryptographyProcessor>().As<ICryptographyProcessor>().InstancePerLifetimeScope();

        builder.RegisterType<EmailService>().As<IEmailService>().InstancePerLifetimeScope();

        builder.RegisterType<TCKimlikService>().As<ITCKimlikService>().InstancePerLifetimeScope();
        
        builder.RegisterType<TwoFactorAuthService>().As<ITwoFactorAuthService>().SingleInstance();

        builder.RegisterType<LoggerService>().As<ILoggerService>().SingleInstance();
        
        // ValidationFilterAttribute Scoped
        builder.RegisterType<ValidationFilterAttribute>().InstancePerLifetimeScope();
        // LogFilterAttribute Singleton
        builder.RegisterType<LogFilterAttribute>().SingleInstance();

        // ApiBehaviorOptions Configuration
        builder.Register(c =>
        {
            var options = new ApiBehaviorOptions();
            options.SuppressModelStateInvalidFilter = true;
            return Microsoft.Extensions.Options.Options.Create(options);
        }).SingleInstance();
        

        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new UserBusinessMapping());
            mc.AddProfile(new UserUIMapping());


        });
        
        
        IMapper mapper = mappingConfig.CreateMapper();
        builder.RegisterInstance<IMapper>(mapper);
    }
}