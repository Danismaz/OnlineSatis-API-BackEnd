using DataAccess.Context.ApplicationContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.Sockets;
using System.Text;
using Business.Sevices.Concrete;
using Business.Sevices.Interfaces;
using DataAccess.Repositories.Concrete;
using DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using KYSProjectApi.Autofac;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using NLog;
using KYSProjectApi.Extensions;
using Business.AutoMapper;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

var connectionString = builder.Configuration.GetConnectionString("EntityConnection");

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseNpgsql(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});


builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true, // İzin verilen sitelerin denetlenip denetlenmeyeceği
        ValidateIssuer = true,
        ValidateLifetime = true, // Token yaşam süresi kontrolü
        ValidateIssuerSigningKey = true, // Token'ın bize ait olup olmadığını kontrolü
        ValidIssuer = builder.Configuration["Token:Issuer"],
        ValidAudience = builder.Configuration["Token:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
        ClockSkew = TimeSpan.Zero
    };
});

// Google OAuth kimlik doğrulama
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
})
.AddCookie()
.AddGoogle(GoogleDefaults.AuthenticationScheme, options =>
{
    var googleAuthNSection = builder.Configuration.GetSection("Authentication:Google");
    options.ClientId = googleAuthNSection["ClientId"];
    options.ClientSecret = googleAuthNSection["ClientSecret"];
    options.CallbackPath = new PathString("/Account/signin-google");
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutofacApiModule());
                });

// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("KYSProjectPolicy",
//         policy =>
//         {
//             policy.WithOrigins("http://localhost:5198", "http://localhost:7203" , "http://localhost:5198")
//                 .AllowAnyMethod()
//                 .AllowAnyHeader();
//         });
// });
builder.Services.AddCors(options =>
{
    options.AddPolicy("KYSProjectPolicy",
        policy =>
        {
            policy
                .AllowAnyOrigin()   // Tüm kökenlerden gelen istekleri kabul eder
                .AllowAnyMethod()   // Her türlü HTTP yöntemini kabul eder
                .AllowAnyHeader();  // Her türlü HTTP başlığını kabul eder
        });
});


// Add services to the container.

builder.Services.AddControllers(config =>
    {
        config.RespectBrowserAcceptHeader = true;
        config.ReturnHttpNotAcceptable = true;
    });
    // .AddXmlDataContractSerializerFormatters();

builder.Services.Configure<ApiBehaviorOptions>(options => 
{
    options.SuppressModelStateInvalidFilter = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(UserBusinessMapping));


var app = builder.Build();

//var logger = app.Services.GetRequiredService<ILoggerService>();
//app.ConfigureExceptionHandler(logger);

// Otomatik migration
using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsProduction())
{
    app.UseHsts();
}

app.UseCors("KYSProjectPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
