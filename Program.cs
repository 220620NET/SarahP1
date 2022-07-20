using Microsoft.AspNetCore.Mvc;
using ClassLibraryModels;
using ClassLibraryServices;
using ClassLibraryDAO;
using WebAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);
//dependency injection handled by ASP.NET Core
//Singleton, Scoped, Transient
builder.Services.AddSingleton<ConnectionFactory>(ctx => ConnectionFactory.GetInstance(builder.Configuration.GetConnectionString("UserDB")));

//DAO

builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<ITicketRepository, TicketRepository>();

//services


builder.Services.AddTransient<AuthService>();
builder.Services.AddTransient<UserService>();
builder.Services.AddScoped<TicketService>();

//Controller
builder.Services.AddScoped<TicketController>();
builder.Services.AddScoped<AuthController>();
builder.Services.AddTransient<UserController>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/user/register", (UserModel newUser, AuthController controller) => controller.CreateUser(newUser));
//app.MapPost("/user/login", (UserModel newUser, AuthController controller) => controller.CreateUser(newUser));

app.MapGet("/user/getallusers", (UserController controller) => controller.GetAllUsers());
app.MapGet("/user/getuserbyid/{id}", (int id, UserController controller) => controller.GetUser(id));
app.MapGet("/user/getuserbyusername/{userName}", (string userName, UserController controller) => controller.GetUserByUserName(userName));


app.Run();
