using Microsoft.AspNetCore.Mvc;

using ClassLibraryServices;
using ClassLibraryDAO;
using WebAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);
//dependency injection handled by ASP.NET Core
//Singleton, Scoped, Transient
builder.Services.AddSingleton<ConnectionFactory>(ctx => ConnectionFactory.GetInstance(builder.Configuration.GetConnectionString("UserDB")));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddTransient<AuthService>();
builder.Services.AddTransient<UserService>();
builder.Services.AddScoped<AuthController>();
builder.Services.AddTransient<UserController>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/users", (UserController controller) => controller.GetAllUsers());
app.MapGet("/getbyid", (UserController controller) => controller.GetUser());



app.MapGet("/", () => "Hello Sarah!");
app.MapGet("/greet/{name}", (string name) =>
{
    return $"Hi {name}";
});
app.MapPost("greet", (string name) =>
{
    return $"Hello {name}";
});
app.Run();
